using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    /****************************************
     * This script will create a projectile 
     * at a given spawnpoint when a key is pressed.
     * The projectile prefab should already have 
     * a script on it that makes it move forward
     * ***************************************/

    //VARIABLES

    // projectilePrefab is a GameObject that will be instantiated
    // when the given key is pressed.

    public GameObject projectilePrefab;

    // projectileSpawnPoint is the location that will determine
    // the position and rotation of the projectils

    public GameObject projectileSpawnPoint;

    //shootKey will allow you to choose which key is used to shoot.

    public KeyCode shootKey = KeyCode.LeftControl;

  
    void Update()
    {
        if(Input.GetKeyDown(shootKey))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
        }
        
    }
}
