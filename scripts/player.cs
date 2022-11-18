using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    //movement
    private float horizontalInput;
    public float moveSpeed;

    public bool isPoweredUp = false;
    public GameObject respawn;

    public ParticleSystem respawnParticles;
    
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

    }
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Bullet") && isPoweredUp == false)
        {
            transform.position = respawn.transform.position;
            respawnParticles.Play();

        }

    }


}
