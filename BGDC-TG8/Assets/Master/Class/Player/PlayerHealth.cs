using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    public float maxHealth { get ; set ; }
    public float currentHealth { get ; set ; }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            //playerDies();
        }
    }
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }
}
