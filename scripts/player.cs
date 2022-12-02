using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    //movement
    private float horizontalInput;
    public float moveSpeed;

   
    public GameObject respawn; //respawn
    public bool HasPowerUp; //powerup
    public GameObject projectileSpawnPoint; //bullet spawn
    public GameObject projectilePrefab; //the bullet
    public ParticleSystem respawnParticles; //particles
    public float shootTime; //shoot time
    public bool lifes = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed * horizontalInput);
        if(lifes == true)
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        
       
        if (other.gameObject.CompareTag("Bullet") && HasPowerUp == false)
            {
                transform.position = respawn.transform.position;
                 respawnParticles.Play();
            lifes = true; 
            }
        if (other.gameObject.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            HasPowerUp = true;
            
        }
      }
}
