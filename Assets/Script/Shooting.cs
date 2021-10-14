using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform camTf;
    public GameObject bullet;
    public float speed=20;

    void Start()
    {
        // go =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go=Instantiate(bullet);
            go.transform.position = camTf.position;
            go.transform.rotation = camTf.rotation;
            go.GetComponent<Rigidbody>().velocity = camTf.forward * speed;;
            //go.GetComponent<Rigidbody>().velocity = new Vector3(1,0,0);
        }
    }

}
