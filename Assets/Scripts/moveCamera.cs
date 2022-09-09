using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    // public float rSpeed;
    public float mSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.position += Vector3.left * mSpeed;
        }else
        if(Input.GetKey(KeyCode.S)){
            transform.position += Vector3.down * mSpeed;
        }else
        if(Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * mSpeed;
        }else 
        if(Input.GetKey(KeyCode.W)){
            transform.position += Vector3.up * mSpeed;
        }
        
    }
}
