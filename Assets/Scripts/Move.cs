using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float number;
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(go.name);
        go = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        go.transform.Rotate(Vector3.up, 0.05f);

    }
}
