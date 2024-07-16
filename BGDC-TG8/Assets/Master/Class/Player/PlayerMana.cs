using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    public float maxMana = 100;
    public float currentMana;
    public float manaRegen = 1;

    public GameEvent onPlayerManaChanged;

    void Start()
    {
        currentMana = maxMana;
    }

    void Update()
    {
        if(currentMana <= 100)
        {
            currentMana += manaRegen * Time.deltaTime;
            onPlayerManaChanged.Raise(this, currentMana);
        }
    }

    public void UseMana(Component sender, object data)
    {
        Debug.Log("MAGIC!");
        float manaUsed = (float)data;
        currentMana -= manaUsed;

        onPlayerManaChanged.Raise(this, currentMana);
    }
}
