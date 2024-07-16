using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    public float maxHealth { get ; set ; }
    public float currentHealth { get ; set ; }

    public GameEvent onPlayerHealthChanged;

    public void takeDamage(Component sender, object data)
    {
        Debug.Log("damaged");
        if (data is float)
        {
            float damageAmount = (float)data;
            currentHealth -= damageAmount;
            Debug.Log(currentHealth);

            if (currentHealth <= 0)
            {
                playerDies();
            }

            onPlayerHealthChanged.Raise(this, currentHealth);
        }
        else { Debug.Log("damageAmount is not float"); }
    }

    public void heal(Component sender, object data)
    {
        Debug.Log("healed");
        if (data is float)
        {
            float healAmount = (float)data;
            currentHealth += healAmount;
            Debug.Log(currentHealth);

            if(currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
            }

            onPlayerHealthChanged.Raise(this, currentHealth);
        }
        else { Debug.Log("healAmount is not float"); }

    }

    void playerDies()
    {
        Debug.Log("Dies");
    }

    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
    }

}
