using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAreaTest : MonoBehaviour
{
    GameObject player;
    public PlayerHealth PlayerHealth;

    int healAmount = 10;


    void Awake()
    {
        player = GameObject.Find("Health");
        //PlayerHealth = player.GetComponent<PlayerHealth>;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //PlayerHealth.heal(healAmount);
            Debug.Log(healAmount);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

}
