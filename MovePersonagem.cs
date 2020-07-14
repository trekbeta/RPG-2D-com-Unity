﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour {

    private float vel;
    private Vector2 direcao;
    public Animator anim;

    // Start is called before the first frame update
    void Start() {
        vel = 3;
        direcao = Vector2.zero;
    }

    // Update is called once per frame
    void Update()    {
        InputPersonagem();
        transform.Translate(direcao * vel * Time.deltaTime);
        
        Animato(direcao);

    }

    void InputPersonagem()
    {
        direcao = Vector2.zero;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            direcao += Vector2.up;
        }
         if(Input.GetKey(KeyCode.DownArrow))
        {
           direcao += Vector2.down; 
        }
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector2.left;
        }
         if(Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector2.right;
        }
    }

    void Animato(Vector2 dir)
    {
        anim.SetFloat("x", dir.x);
        anim.SetFloat("y", dir.y);    
    }
}
