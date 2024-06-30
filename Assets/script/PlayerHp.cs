using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHp : MonoBehaviour
{
    public int hp = 3;
    
    public UnityEvent onTakeDamage;
    private void TakeDamage()
    {
        hp--;
        if (hp == 0)
        {
            Die();
        }
        
        onTakeDamage.Invoke();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage();
        }
        
        Destroy(other.gameObject);
    }
}
