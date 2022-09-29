using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMvnt : MonoBehaviour
{
    public float speed;
    public float minDirection = 0.5f;
    public AudioSource audio; 
    private Vector3 direction;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.RandomDirection();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        this.rb.MovePosition(this.rb.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Wall")){

            audio.Play();
            direction.z = -direction.z;
        }
        if(other.CompareTag("Racket")){

            audio.Play();
            Vector3 newDirection = (transform.position - other.transform.position).normalized;

            newDirection.x = Mathf.Sign(newDirection.x)*Mathf.Max(Mathf.Abs(newDirection.x), this.minDirection);
            newDirection.z = Mathf.Sign(newDirection.z)*Mathf.Max(Mathf.Abs(newDirection.z), this.minDirection);

            direction = newDirection;
        }
    }

    private void RandomDirection(){
        float signX = Mathf.Sign(Random.Range(-1f, 1f));
        float signZ = Mathf.Sign(Random.Range(-1f, 1f));
        this.direction = new Vector3(0.5f * signX, 0, 0.5f * signZ);
    }
}
