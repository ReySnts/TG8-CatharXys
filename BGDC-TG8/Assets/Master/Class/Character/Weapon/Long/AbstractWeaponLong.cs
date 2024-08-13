using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractFactory<Vector2>))]

public abstract class AbstractWeaponLong : AbstractWeapon
{
    [SerializeField] protected float fireRate = 1f;

    protected AbstractFactory<Vector2> bulletFactory;

    protected override void Awake()
    {
        base.Awake();
        bulletFactory = GetComponent<AbstractFactory<Vector2>>();
    }
}