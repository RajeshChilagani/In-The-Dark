using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savePoint : MonoBehaviour {

    // Use this for initialization
    public GameObject con;
    public int save = 2;
    private main p;
    private void OnTriggerEnter(Collider other)
    {
        p = con.GetComponent<main>();
        p.savepoint = save;
    }
    

}
