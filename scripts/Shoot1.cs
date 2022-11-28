using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot1 : MonoBehaviour
{
    public GameObject projectilePrefab;//projectile

    public GameObject projectileSpawnPoint; //spawnpoint
   
    public float spawnTime; //spawner time

    public GameObject Respawn; //respawn

    public bool HasPowerUp;

    public float shootTime; //shooting time
    void Start()
    {

        StartCoroutine(BulletSpawn());
    }
    void Update()
    {
        

    }
    IEnumerator BulletSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootTime);
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position = Respawn.transform.position;
        
        if (gameObject.CompareTag("Player") && HasPowerUp == true)
        {
            shootTime = 1;
        }
    }
    IEnumerator PowerUp()
    {
        if (gameObject.CompareTag("Player") && HasPowerUp == true)
        {
            while (true)
            {
                yield return new WaitForSeconds(shootTime);
                shootTime = 1;
            }
            
        }
    }

}
