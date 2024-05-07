using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public float spawnInterval = 5;
    public GameObject ufoPrefab1;
    public GameObject ufoPrefab2;
    public GameObject ufoPrefab3;
    public GameObject ufoPrefab4;
    public GameObject ufoPrefab5;
    public GameObject ufoPrefab6;
    public GameObject ufoPrefab7;
    public GameObject ufoPrefab8;
    public GameObject ufoPrefab9;
    public GameObject ufoPrefab10;
    public Transform ufo1SpawnPoint;
    public Transform ufo2SpawnPoint;
    public Transform ufo3SpawnPoint;
    public Transform ufo4SpawnPoint;
    public Transform ufo5SpawnPoint;
    public Transform ufo6SpawnPoint;
    public Transform ufo7SpawnPoint;
    public Transform ufo8SpawnPoint;
    public Transform ufo9SpawnPoint;
    public Transform ufo10SpawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        //ufo1.position = new Vector3(-169f, 268f, 0f);
        StartCoroutine(SpawnObject());

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            moveSpeed *= -1;
        }
    }
    IEnumerator SpawnObject()
    {
        while (true)
        {
            Instantiate(ufoPrefab1, ufo1SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab2, ufo2SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab3, ufo3SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab4, ufo4SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab5, ufo5SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab6, ufo6SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab7, ufo7SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab8, ufo8SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab9, ufo9SpawnPoint.position, Quaternion.identity);
            Instantiate(ufoPrefab10, ufo10SpawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
