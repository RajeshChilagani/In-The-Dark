using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour {

    // Use this for initialization
    private LightIntensity lightIntensity;
    public GameObject Panel;
    Text LT;
    Image bulbon;
    Image bulboff;
    Image bulb25;
    Image bulb50;
    private void Awake()
    {
        lightIntensity = GetComponent<LightIntensity>();
        LT = Panel.transform.Find("Text").GetComponent<Text>();
        bulbon = Panel.transform.Find("bulbon").GetComponentInChildren<Image>();
        bulboff = Panel.transform.Find("bulboff").GetComponentInChildren<Image>();
        bulb25 = Panel.transform.Find("bulb25").GetComponentInChildren<Image>();
        bulb50 = Panel.transform.Find("bulb50").GetComponentInChildren<Image>();

    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lightIntensity.lTimeOut > 0.1)
        {
            LT.text = "WAIT UNTIL CHARGED ";
            bulbon.enabled = false;
            bulboff.enabled = true;
            bulb25.enabled = false;
            bulb50.enabled = false;
            if (lightIntensity.lTimeOut < 4)
            {
                bulbon.enabled = false;
                bulboff.enabled = false;
                bulb25.enabled = true;
                bulb50.enabled = false;
            }
            if (lightIntensity.lTimeOut < 2)
            {
                bulbon.enabled = false;
                bulboff.enabled = false;
                bulb25.enabled = false;
                bulb50.enabled = true;
            }

        }
        else
        {
            if (lightIntensity.sTimeOut > 0.1)
            {
                LT.text = "PRESS F TO GET MORE LIGHT";
                bulboff.enabled = false;
                bulbon.enabled = true;
                bulb25.enabled = false;
                bulb50.enabled = false;
                if (lightIntensity.sTimeOut <2 )
                {
                    bulbon.enabled = false;
                    bulboff.enabled = false;
                    bulb25.enabled = false;
                    bulb50.enabled = true;
                }
                if (lightIntensity.sTimeOut < 1)
                {
                    bulbon.enabled = false;
                    bulboff.enabled = false;
                    bulb25.enabled = true;
                    bulb50.enabled = false;
                }
            }
        }
       

        
	}
}
