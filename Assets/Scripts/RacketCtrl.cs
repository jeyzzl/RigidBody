using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketCtrl : MonoBehaviour
{
    public float speed;
    public KeyCode up;
    public KeyCode down;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedUp = Input.GetKey(this.up);
        bool pressedDown = Input.GetKey(this.down);

        if(pressedUp){
            rb.velocity = Vector3.forward * speed;
        }
        if(pressedDown){
            rb.velocity = Vector3.back * speed;
        }
        if(!pressedUp && !pressedDown){
            rb.velocity = Vector3.zero;
        }

    }
}
