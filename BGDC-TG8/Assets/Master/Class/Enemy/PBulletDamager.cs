using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBulletDamager : MonoBehaviour
{
    [SerializeField] private float BulletDamage = 25f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable idmg = collision.gameObject.GetComponent<IDamageable>();

        if(idmg != null)
        {
            idmg.Damage(BulletDamage);
        }
    }
}
