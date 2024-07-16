using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAreaTest : MonoBehaviour
{
    public GameEvent onPlayerDamaged;

    float damageAmount = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //PlayerHealth.takeDamage(damageAmount);
            Debug.Log(damageAmount);
            onPlayerDamaged.Raise(this, damageAmount);
        }
    }

}
