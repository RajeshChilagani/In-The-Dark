using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour
{

    // Use this for initialization
    public double lTimeOut = 20;
    public double sTimeOut = 10;
    private Light lightc;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (lTimeOut >0.1)
        {
            lTimeOut = lTimeOut - 0.001;
            sTimeOut = 3;
        }
        if (lTimeOut <=0.1)
        {
            lightc = GetComponent<Light>();
            if (Input.GetKeyDown(KeyCode.F))
            {
                lightc.range = 25;
                lightc.intensity = 2;
                


            }
            if (sTimeOut > 0.1)
            {
                sTimeOut = sTimeOut - 0.001;
            }
            if (sTimeOut <= 0.1)
            {
                lightc.range = 15;
                lightc.intensity = 1;
                lTimeOut = 5;
            }


        }
    }
}
