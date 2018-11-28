using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {

    // Use this for initialization
    //public GameObject Player;
    public Transform transform;
    public Transform transform1;
    public Transform transform2;
    //public GameObject spawnedPlayer;
    public GameObject fps;
    private main f;

    

    private void OnTriggerEnter(Collider other)
    {
        f = fps.GetComponent<main>();
        

        
        if (f.savepoint == 1)
        {
            f.spawnedPlayer = Instantiate(f.Player, transform.position, transform.rotation);
            Destroy(f.Player);
            f.Player = f.spawnedPlayer;
        }
        if (f.savepoint == 2)
        {
            f.spawnedPlayer = Instantiate(f.Player, transform1.position, transform1.rotation);
            Destroy(f.Player);
            f.Player = f.spawnedPlayer;
        }
        if (f.savepoint == 3)
        {
            f.spawnedPlayer = Instantiate(f.Player, transform2.position, transform2.rotation);
            Destroy(f.Player);
            f.Player = f.spawnedPlayer;
        }
    }
    
}
