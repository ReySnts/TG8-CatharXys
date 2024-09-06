using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    abstract float maxHealth { get; set; }
    abstract float currentHealth { get; set; }

    public void takeDamage(Component sender, object data);

    public void heal(Component sender, object data);
}
