using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deklete : MonoBehaviour {
    public GameObject destroy;
    // Use this for initialization
    public GameObject desmen;

    public void Enable()
    {
        desmen.SetActive(true);

    }
    public void startsu()
    {
        
    }
    public void Disable()
    {
        desmen.SetActive(false);
    }
    public void Amazing()
    {
        desmen.SetActive(true);
        destroy.SetActive(false);
    }
    void Start()
    {
        
    }

    void Update()
    {

    }
    
}
