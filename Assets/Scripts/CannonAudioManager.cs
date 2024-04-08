using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip shoot;
    [SerializeField] AudioClip shootAbility;


    //Kauanko laukauksien välissä on vähintään aikaa. Tämä on ettei audio täysin hajoa suurilla ampumisnopeuksilla.
    [SerializeField] float delayBetweenShots = 0.1f;
    float nextShot = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot(bool ability)
    {
        if (Time.time >= nextShot)
        {
            if (ability)
            {
                audioSource.PlayOneShot(shootAbility);
            }
            else
            {
                audioSource.PlayOneShot(shoot);
            }

            nextShot = Time.time + delayBetweenShots;

        }
    }

}
