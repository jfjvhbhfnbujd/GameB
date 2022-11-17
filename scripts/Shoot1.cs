using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot1 : MonoBehaviour
{
    public GameObject projectilePrefab; //projectile
    public GameObject projectileSpawnPoint; //spawnpoint
    public float spawnTime; //spawner time
    public GameObject Respawn;
    void Start()
    {

        StartCoroutine(BulletSpawn());
    }
    void Update()
    {
      
    }
    IEnumerator BulletSpawn()
    {
        yield return new WaitForSeconds(1);
        Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
        
    }
    private void OnCollisionEnter(Collision collision)
    {



        collision.transform.position = Respawn.transform.position;
    }

}
