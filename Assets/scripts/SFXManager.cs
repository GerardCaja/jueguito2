using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip playerDeath;

    private AudioSource source;

    public AudioClip objects;

    private void Awake() 
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayerDeath()
    {
        source.PlayOneShot(playerDeath);
    }

    public void Objects()
    {
        source.PlayOneShot(objects);
    }
}
