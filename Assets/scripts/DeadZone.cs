using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    BoxCollider2D boxCollider;

    SFXManager sfxManager;
    SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();

        sfxManager = GetComponent<SFXManager>();
        soundManager = GetComponent<SoundManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "PlayerController")
        {
            Destroy(other.gameObject);
            sfxManager.PlayerDeath();
            soundManager.StopBGM();
        }
    }
}
