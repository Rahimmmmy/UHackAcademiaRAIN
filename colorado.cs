using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorado : MonoBehaviour {



    public Material color1;
    public Material color2;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = color1;
	}

    public void look()
    {
        GetComponent<Renderer>().material = color2;
    }

    public void dontlook(
        )
    {
        GetComponent<Renderer>().material = color1;
    }
	
	void Update () {
		
	}
}
