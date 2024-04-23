using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    public AudioSource myAudioSource;
    public AudioClip myAudioClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        myAudioSource.PlayOneShot(myAudioClip);
    }
}
