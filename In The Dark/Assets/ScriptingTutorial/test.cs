using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    // Use this for initialization
    public CapsuleCollider cp;
    public float moveSpeed = 5.0f;
    private GameObject villan;
    private RaycastHit hit;
    private Ray ray;
    public float rayDistance=3.0f;
    private Animator anim;
    
    

    void Start () {
        cp = GetComponent<CapsuleCollider>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.Translate(movement*Time.deltaTime*moveSpeed);
        Animating(moveHorizontal, moveVertical);

        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin+new Vector3(0f,cp.center.y,0f), ray.direction * rayDistance, Color.blue);    
        if(Physics.Raycast(ray,out hit))
        {
            Debug.Log(hit.collider.gameObject.tag);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Villan")
        {
            Debug.Log("collidede with"+ collision.gameObject.tag);
        }
        
    }
    void Animating(float a,float b)
    {
        bool running = a != 0f || b != 0f;
        anim.SetBool("IsRunning", running);
    }
   
}
  