using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeeperHealthBar : MonoBehaviour
{
    private Image image; 

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void UpdateHealth(float maxHealth, float currentHealth)
    {
        image.fillAmount = currentHealth / maxHealth; 
    }
}
