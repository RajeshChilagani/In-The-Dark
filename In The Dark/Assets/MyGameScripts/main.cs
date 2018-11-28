using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

    // Use this for initialization
    public int savepoint;
    public GameObject Player;
    public Transform transform;
    public Transform transform1;
    public Transform transform2;
    public GameObject spawnedPlayer;
    void Start () {
        if (savepoint == 1)
        {
            spawnedPlayer = Instantiate(Player, transform.position, transform.rotation);
            Destroy(Player);
            Player = spawnedPlayer;
        }
        if (savepoint == 2)
        {
            spawnedPlayer = Instantiate(Player, transform1.position, transform1.rotation);
            Destroy(Player);
            Player = spawnedPlayer;
        }
        if (savepoint == 3)
        {
            spawnedPlayer = Instantiate(Player, transform2.position, transform2.rotation);
            Destroy(Player);
            Player = spawnedPlayer;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
