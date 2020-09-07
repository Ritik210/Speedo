using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 8000f;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float Vert;
    public float gravity = 50.0f;

    //public Animator anim;
    protected Joystick Joystick;
    float VerticalMove;

    // Start is called before the first frame update
    void Start()
    {
        Joystick = FindObjectOfType<Joystick>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(Joystick.Horizontal * sidewaysForce * Time.deltaTime, rigidbody.velocity.y, Joystick.Vertical * speed*Time.deltaTime);

        VerticalMove = Joystick.Vertical * 100f;

        if (transform.position.y>28f)
        {
            Vert -= gravity * Time.deltaTime;
        }

      /* if ((VerticalMove == ) && transform.position.y > 30f)
        {
            anim.Play("Flip");
            speed = 8000f;
        }*/
       
        if (rigidbody.position.z > -151f)
        {
            FindObjectOfType<GameManager>().CompleteLevel();

        }
    }
}
