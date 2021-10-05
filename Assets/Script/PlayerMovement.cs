using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.5f;
    public Transform cameraPlayer;
    public float angleLin = 16;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float angle = cameraPlayer.rotation.eulerAngles.x;
        if(angle>angleLin){
            Vector3 direccion = cameraPlayer.forward * speed;
            direccion = new Vector3(direccion.x,0.05f,direccion.z);
            GetComponent<Rigidbody>().velocity = direccion;
        }else{
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }
    }
}
