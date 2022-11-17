using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileControl : MonoBehaviour
{
    public float bulletSpeed2;
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BulletSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed2);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
             
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    IEnumerator BulletSpawn()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
