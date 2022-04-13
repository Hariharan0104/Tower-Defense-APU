using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed ;
    public float health = 100;

    public float slowPct = .5f;

    void Start()
    {
        speed = startSpeed;
    }

    public void Slow()
    {
	    speed = startSpeed * (1f- slowPct);
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        Slow();

        Invoke("OldSpeed", 1.0f);
        

        if(health<=0)
        {
            Die();
        }
    }
    
    public void OldSpeed()
    {
        speed = startSpeed;
    }

    void Die()
    {
        Destroy(gameObject);
     }


}
