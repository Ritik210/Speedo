﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            if(transform.position.y>30f)
            anim.Play("Flip");

        }
       
        
       
        
    }
}
