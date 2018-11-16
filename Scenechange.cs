using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour {

    // Use this for initialization


    public void changescene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);


    }

    public void quitapp()
    {
        Application.Quit();
   }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
