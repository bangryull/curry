using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    
    public Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigid.position += Vector2.left * (Time.deltaTime * speed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rigid.position += Vector2.right * (Time.deltaTime * speed);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            rigid.position += Vector2.up * (Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid.position += Vector2.down * (Time.deltaTime * speed);
        }
    }
}
