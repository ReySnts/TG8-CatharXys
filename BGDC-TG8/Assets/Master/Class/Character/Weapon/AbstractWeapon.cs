using UnityEngine;

public abstract class AbstractWeapon : MonoBehaviour
{
    public AbstractPositioner Positioner { get; private set; }

    public AbstractRotator Rotator { get; private set; }

    public WeaponAim Aim { get; private set; }

    protected abstract void Trigger();

    protected virtual void Awake()
    {
        Aim = GetComponentInChildren<WeaponAim>();
        Positioner = GetComponentInChildren<AbstractPositioner>();
        Rotator = GetComponentInChildren<AbstractRotator>();
    }
}