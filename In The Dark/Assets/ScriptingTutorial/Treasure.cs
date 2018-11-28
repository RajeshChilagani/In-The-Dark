using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour {

    // Use this for initialization
    private Animator anim;
    private bool isTreasure;
    public Rigidbody coinPrefab;
    public Transform spwaner;
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(isTreasure && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("openChest", true);
            Rigidbody coin;
            coin = Instantiate(coinPrefab, spwaner.position, spwaner.rotation);
        }
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hero")
        {
            isTreasure = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hero"){
            isTreasure = false;
        }
    }
}
