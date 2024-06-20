using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    GameObject Fill = GameObject.Find("Fill");
    Image fillImage = Fill.GetComponent<Image>();

    GameObject player;
    PlayerHealth playerHealth;

    void updateHealthBar()
    {
        
        fillImage.fillAmount = playerHealth.currentHealth/100f;
        
    }

    private void Awake()
    {
        player = GameObject.Find("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
