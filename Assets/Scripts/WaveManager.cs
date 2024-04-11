using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class WaveManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI deadScoreText;

    [SerializeField] PlayerCannon player;
    [SerializeField] GameObject deadScreen;
    [SerializeField] GameObject UI;
    [SerializeField] Score score;
    public EventHandler playerDied;

    //[SerializeField] int zombieAmmount;
    //[SerializeField] int zombiesKilled;

    // [Header("Zombie")]
    //  [SerializeField] int baseZombieAmmount;
    //  [SerializeField] int zombiesPerWave;
    //  [SerializeField] float movementSpeed;
    //  [SerializeField] float speedIncrease;
    //  [SerializeField] int baseHP;
    //   [SerializeField] float HPIncrease;
    //  [SerializeField] int baseDamage;
    //   [SerializeField] int damageIncrease;

    //  [Header("")]
    //   [SerializeField] GameObject zombiePrefab;
    //   [SerializeField] List<GameObject> zombies = new List<GameObject>();
    //   [SerializeField] Transform[] spawnPoints;

    //   int layerOrder = 0;



    // Start is called before the first frame update
    void Start()
    {
       player.playerDied += OnPlayerDead;

        deadScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    StartCoroutine(StartNextWave());
        //}

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GoToMainMenu();
        }


    }

   // void StartWave()
  //  {
   //     zombieAmmount = baseZombieAmmount + zombiesPerWave;
    //    zombiesKilled = 0;
    //    for (int i = 0; i < zombieAmmount; i++)
     //   {
     //       SpawnEnemy();
     //   }
//    }

    // Uudelleen käytetään kuolleita zombeja.
    // Jos on saatavilla kuollut zombi (Inactive). Asetetaan tälle uusi hp ja viedään spawni pisteelle
    // Muuten luodaan kokonaan uusi
    //void SpawnEnemy()
   // {
     //   bool foundInactive = false;
     //
       // Vector3 spawnPosition = GetSpawnpoint();
       
       // foreach (GameObject zombie in zombies)
        //{
          //  if (zombie.activeInHierarchy == false)
            //{
              //  zombie.SetActive(true);
                //zombie.transform.position = spawnPosition;

                //EnemyHPController enemyHPController = zombie.GetComponent<EnemyHPController>();
                //EnemyController enemyController = zombie.GetComponent<EnemyController>();
                //SetZombieStats(enemyController);

            //    foundInactive = true;
           //     break;
      //      }
     //   }

   //     if (!foundInactive)
     //   {
       //     GameObject zombie = Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
         //   EnemyController enemyController = zombie.GetComponent<EnemyController>();

           // SetZombieStats(enemyController);
            //enemyController.SetLayerOrder(layerOrder);
            //layerOrder++;

           // enemyController.Died += OnZombieDead;
            
         //   zombie.SetActive(true);
        //    zombies.Add(zombie);

    //    }
  //  }

   // void SetZombieStats(EnemyController zombie)
  //  {
        

        //int hp = baseHP + HPIncrease * multiplier;
   //     int hp = (int)(baseHP + baseHP * HPIncrease);
   //     int attackDamage = baseDamage + (damageIncrease);

   //     float speed = movementSpeed + (speedIncrease);

  //      zombie.SetStats(hp, speed, attackDamage);
 //   }

    //void OnZombieDead(System.Object sender, EventArgs e)
  //  {
   //     zombiesKilled++;
   //     score.AddScore(10);
   //     if (zombiesKilled == zombieAmmount)
    //    {
      //      score.AddScore(100);
     //   }
  //  }

    void OnPlayerDead(System.Object sender, EventArgs e)
    {
        deadScreen.SetActive(true);
        UI.SetActive(false);
       // deadScoreText.text = score.score.ToString();
      //  Debug.Log(score.score.ToString());

    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //    Vector3 GetSpawnpoint()
  //  {
   //     int spawnIndex = UnityEngine.Random.Range(0, spawnPoints.Length);
   //     Vector3 spawnPosition = spawnPoints[spawnIndex].position;
    //    spawnPosition.y += UnityEngine.Random.Range(-3, 3);
   //     spawnPosition.x += UnityEngine.Random.Range(-3, 3);


     //   return spawnPosition;
  //  }

}
