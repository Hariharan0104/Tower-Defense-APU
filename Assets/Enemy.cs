using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed ;
    public float startHealth = 100;
    private float health;

    public float slowPct = .5f;

    //public GameObject deathEffect;

    public Image healthBar;

    void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void Slow()
    {
	    speed = startSpeed * (1f- slowPct);
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health/startHealth;
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
