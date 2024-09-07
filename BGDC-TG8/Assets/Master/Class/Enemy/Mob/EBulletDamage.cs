using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBulletDamage : MonoBehaviour
{
    public GameEvent onPlayerDamaged;

    float damageAmount = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            onPlayerDamaged.Raise(this, damageAmount);
        }
    }

}
