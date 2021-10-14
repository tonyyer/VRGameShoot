using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent NVagent;
    public Vector3 randomPosition;
    float elapsed;

    Text scoreTxt;
    void Start()
    {
        elapsed = 1000;

        scoreTxt = GameObject.Find("score").GetComponent<Text>();
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

        private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="bullet"){
            Destroy(collision.gameObject,0.1f);
            Destroy(gameObject,0.1f);

            scoreTxt.text = ""+ (int.Parse(scoreTxt.text)+1);
        }
    }
}
