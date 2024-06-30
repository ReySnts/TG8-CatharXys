using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    public float maxHealth { get ; set ; }
    public float currentHealth { get ; set ; }

    public GameEvent onPlayerHealthChanged;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject objectCollisioned = GameObject.Find(collision.gameObject.name);

        if (collision.CompareTag("Damage"))
        {

            //float damageAmount;
            //takeDamage();
        }
        else if (collision.CompareTag("Heal"))
        {

            //float healAmount;
            //heal();
        }
    }

    public void takeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log(currentHealth);

        if (currentHealth <= 0)
        {
            playerDies();
        }
    }

    void playerDies()
    {
        Debug.Log("Dies");
    }

    public void heal(float healAmount)
    {
        Debug.Log(currentHealth);
    }
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }
}
