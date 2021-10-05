using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent NVagent;
    public Vector3 randomPosition;
    float elapsed;
    void Start()
    {
        elapsed = 1000;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        elapsed += Time.fixedDeltaTime;
        if(elapsed > 8 ){
            randomPosition = new Vector3(Random.Range(-10,10),2,Random.Range(-10,10));
            NVagent.SetDestination(randomPosition);
            elapsed = 0;
        }

    }
}
