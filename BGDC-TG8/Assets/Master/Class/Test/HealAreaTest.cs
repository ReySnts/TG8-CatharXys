using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAreaTest : MonoBehaviour
{
    public GameEvent onPlayerHealed;

    float healAmount = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //PlayerHealth.takeDamage(damageAmount);
            Debug.Log(healAmount);
            onPlayerHealed.Raise(this, healAmount);
        }
    }

    private void Awake()
    {
        
    }

}
