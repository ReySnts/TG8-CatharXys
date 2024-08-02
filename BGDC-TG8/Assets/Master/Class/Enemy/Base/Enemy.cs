using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable, IEMoveable
{
    [field: SerializeField] public float MaxHealth{ get; set; } = 100f;
    public float CurrentHealth{ get; set; }

    public Rigidbody2D rb { get; set; }

    public bool IsFacingRight { get; set; } = true;

    public void Start()
    {
        CurrentHealth = MaxHealth;

        rb = GetComponent<Rigidbody2D>();
    }

    public void Damage(float damageAmount)
    {
        CurrentHealth -= damageAmount;

        if(CurrentHealth <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        
    }

    #region Movement Functions

    public void MoveEnemy(Vector2 velocity)
    {
        rb.velocity = velocity; 
        CheckDir(velocity);
    }

    public void CheckDir(Vector2 velocity)
    {
        if(IsFacingRight && velocity.x < 0f)
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            IsFacingRight = !IsFacingRight;
        }

        else if(!IsFacingRight && velocity.x > 0f)
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            IsFacingRight = !IsFacingRight;
        }
    }

    #endregion
}
