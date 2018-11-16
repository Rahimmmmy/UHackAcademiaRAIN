using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour {

    // Use this for initialization

    Vector3 spin;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spin = new Vector3(2f, 2f, 0f);
        transform.Rotate(spin);
	}
}
