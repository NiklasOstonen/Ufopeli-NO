using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip enemyDie;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnDeath(object sender, EventArgs e)
    {
        audioSource.PlayOneShot(enemyDie);
    }
}
