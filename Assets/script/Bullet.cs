using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigid;

    public Vector2 targetDirection;
    public GameObject target;

    public float lifeTime;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        rigid.position += targetDirection * (Time.deltaTime * speed);
    }
    
    public void SetTarget(GameObject player)
    {
        targetDirection = (player.transform.position - transform.position).normalized;
    }
}
