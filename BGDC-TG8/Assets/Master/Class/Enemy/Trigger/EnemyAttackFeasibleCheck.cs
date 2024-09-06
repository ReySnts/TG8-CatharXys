using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackFeasibleCheck : MonoBehaviour
{
    public GameObject PlayerTarget {get; set;}
    private Enemy enemy; 

    private void Awake()
    {
        PlayerTarget = GameObject.FindGameObjectWithTag("Player");

        enemy = GetComponentInParent<Enemy>();
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject == PlayerTarget)
        {
            enemy.SetAttackStatus(true);
        }
    }

    private void OnTriggerExit2D (Collider2D collision)
    {
        if(collision.gameObject == PlayerTarget)
        {
            enemy.SetAttackStatus(false);
        }
    }
}
