using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public float force_x;
    public float force_y;
    public float force_z;

    GameObject proyectil;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            force_x = force_x - 5000;
        }
         if(Input.GetKeyDown(KeyCode.RightArrow)){
            force_x = force_x + 5000;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            force_y = force_y - 5000;
        }
         if(Input.GetKeyDown(KeyCode.UpArrow)){
            force_y = force_y + 5000;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            proyectil = Instantiate(proyectilPrefab);

            rb = proyectil.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(force_x, force_y, force_z), ForceMode.Force);

            Destroy(proyectil, 5);
        }
    }
}
