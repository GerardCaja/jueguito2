using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public AudioSource aSource;

    void OnTriggerEnter2D(Collider2D collider)
    {
        aSource.Stop();
    }
}
