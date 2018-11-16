using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class sadddd : MonoBehaviour {

    // Use this for initialization

    NavMeshAgent navMeshAgent;
    public float timerForNewPath;
    bool inCoRoutine;

    void Start() {

        navMeshAgent = GetComponent<NavMeshAgent>();


    }

  void Update()
    {
        if (!inCoRoutine)
            StartCoroutine(DoSomething());
    }

    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(-20, 20);
        float z = Random.Range(-20, 20);

        Vector3 pos = new Vector3(x, 0, z);
        return pos;
    }


    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timerForNewPath);
        GetNewpath();
        inCoRoutine = false;
    }
    // Update is called once per frame
    void GetNewpath() {
        navMeshAgent.SetDestination(getNewRandomPosition());


    }
}
	
   


