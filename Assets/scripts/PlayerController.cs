using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 5.5f;
    public float jumpForce = 10f;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rBody;
    private GroundSensor sensor;
    float hor;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rBody = GetComponent<Rigidbody2D>();
        sensor = GetComponentInChildren<GroundSensor>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(hor * playerSpeed * Time.deltaTime, 0, 0);

        if (hor < 0)
        {
            spriteRenderer.flipX = true;
            anim.SetBool("isRunning", true);
        }
        else if (hor > 0)
        {
            spriteRenderer.flipX = false;
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (sensor.isGrounded)
            {
                rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                anim.SetBool("isJumping", true);
            }
        }
    }
}
