using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
<<<<<<< HEAD
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed ;
    public float health = 100;
=======
    public float speed = 10f;
public int health = 100;
    private Transform target;
    private int wavepointIndex = 0;
>>>>>>> parent of 60de465 (.)

    public float slowPct = .5f;

    void Start()
    {
        speed = startSpeed;
    }

    public void Slow()
    {
	    speed = startSpeed * (1f- slowPct);
        
    }
<<<<<<< HEAD

    public void TakeDamage(float amount)
=======
    public void TakeDamage(int amount)
>>>>>>> parent of 60de465 (.)
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
