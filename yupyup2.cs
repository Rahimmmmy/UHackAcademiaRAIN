using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yupyup2 : MonoBehaviour {



    // Use this for initialization
    public float playerSpeed;
    public GameObject wall;
    public int count;
    public TextMesh totalcoins;
    public AudioSource forduck;
    public AudioSource applause;
    public AudioSource voice;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (count == 10)
        {
          
            wall.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("School"))
        {
            forduck.Play();
            Destroy(other.gameObject);
            count++;
            totalcoins.text = count.ToString();
            if (count == 10)
            {

                applause.Play();
                voice.Play();
            }
        }
    }
}


