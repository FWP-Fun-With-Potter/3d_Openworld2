using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HI");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            rb.AddForce(0,0,15);
        }
        if(Input.GetKey("s")){
            rb.AddForce(0,0,-15);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-15,0,0);
        }
        if(Input.GetKey("d")){
            rb.AddForce(15,0,0);
        }
        if(Input.GetKey("space")){
            rb.AddForce(0,30,0);
        }

    }
}
