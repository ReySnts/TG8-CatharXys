using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    public Slider slider;

    private void Awake()
    {
        slider.value = 100f;
    }
    public void updateHealthBar(Component sender, object data)
    {
        float currentHealth = (float)data;

        slider.value = currentHealth;
    }
}
