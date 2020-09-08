using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   

    // Update is called once per frame
    public Rigidbody rb;
    public float speed = 5000f;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

  
    // Start is called before the first frame update
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))

        {
            rb.AddRelativeForce(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w") && transform.position.y > 30f)
        {
            anim.Play("Flip");
            speed = 8000f;
        }
          //if(transform.position.y )
         if (rb.position.z > -151f)
         {
             FindObjectOfType<GameManager>().CompleteLevel();
            
         }

         
    }
}

