﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	float hor, ver;
	public float sped = 1;
	Rigidbody2D rbd;
   private  Animator anim;
	
	
	void Awake()
	{
		rbd = GetComponent<Rigidbody2D>(); //Llamo el rigidbody que ya he creado
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
		ver = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rbd.velocity = new Vector2(hor * sped, ver * sped);

        if(hor==0 && ver == 0)
        {
            anim.SetBool("move", false);
        }
        else
        {
            anim.SetBool("move", true);
        }

        if (hor >= 0.1)
        {
            anim.SetBool("abajo", false);
            anim.SetBool("izquierda", false);
            anim.SetBool("arriba", false);

            anim.SetBool("derecha", true);
        }
         if(hor <= -0.1)
        {
            anim.SetBool("derecha", false);
            anim.SetBool("abajo", false);
            anim.SetBool("arriba", false);
            anim.SetBool("izquierda", true);
        }
        if(ver >= 0.1)
        {
            anim.SetBool("derecha", false);
            anim.SetBool("izquierda", false);
            anim.SetBool("abajo", false);
            anim.SetBool("arriba", true);
        }
         if(ver <= -0.1)
        {
            anim.SetBool("derecha", false);
            anim.SetBool("izquierda", false);
            anim.SetBool("arriba", false);
            anim.SetBool("abajo", true);
        }

        
    }
}