using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{

    public GameObject objectFill;
    GameObject player;
    PlayerHealth playerHealth;
    Image fillImage;

    void updateHealthBar()
    {
        
        fillImage.fillAmount = playerHealth.currentHealth/100f;
    }

    private void Awake()
    {
        objectFill = transform.GetChild(1).gameObject;
        fillImage = objectFill.GetComponent<Image>();
        player = GameObject.Find("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

}
