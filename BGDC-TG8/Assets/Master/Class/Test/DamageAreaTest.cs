using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAreaTest : MonoBehaviour
{
    public GameObject player;
    public GameObject playerHealth;
    public PlayerHealth PlayerHealth;

    int damageAmount = 10;

    void Awake()
    {
        player = GameObject.Find("Player");
        //playerHealth = transform.GetChild(5).player;
        //PlayerHealth = playerHealth.GetComponent<>;
        Debug.Log(damageAmount);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //PlayerHealth.takeDamage(damageAmount);
            Debug.Log(damageAmount);
        }
    }

}
