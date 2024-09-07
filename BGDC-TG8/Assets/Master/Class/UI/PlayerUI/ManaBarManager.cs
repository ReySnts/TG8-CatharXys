using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBarManager : MonoBehaviour
{
    public Slider slider;

    private void Awake()
    {
        slider.value = 100f;
    }
    public void UpdateHealthBar(Component sender, object data)
    {
        float currentMana = (float)data;

        slider.value = currentMana;
    }
}
