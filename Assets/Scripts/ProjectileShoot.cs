using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab1;
    public GameObject projectilePrefab2;
    public GameObject projectilePrefab3;
    public GameObject projectilePrefab4;
    public GameObject projectilePrefab5;
    public Transform projectile1SpawnPoint;
    public Transform projectile2SpawnPoint;
    public Transform projectile3SpawnPoint;
    public Transform projectile4SpawnPoint;
    public Transform projectile5SpawnPoint;
    public AudioSource audioPlayerShoot;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            audioPlayerShoot.Play();
           // Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Instantiate(projectilePrefab1, projectile1SpawnPoint.position, Quaternion.identity);
            Instantiate(projectilePrefab2, projectile2SpawnPoint.position, Quaternion.identity);
            Instantiate(projectilePrefab3, projectile3SpawnPoint.position, Quaternion.identity);
            Instantiate(projectilePrefab4, projectile4SpawnPoint.position, Quaternion.identity);
            Instantiate(projectilePrefab5, projectile5SpawnPoint.position, Quaternion.identity);
        }
    }
}
