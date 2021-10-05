using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.5f;
    public Transform cameraPlayer;
    public float angleLin = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float angle = cameraPlayer.rotation.eulerAngles.x;
        if(angle<angleLin){
            GetComponent<Rigidbody>().velocity = cameraPlayer.forward*speed;
        }else{
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }
    }
}
