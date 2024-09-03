using UnityEngine;

public sealed class PositionerSpriteWeapon : AbstractPositioner
{
    [SerializeField] private float offsetX = 2f;

    private AbstractWeapon weapon;

    private void Awake() => weapon = GetComponentInParent<AbstractWeapon>();

    private void Update()
    {
        var multiplier = weapon.Aim.transform.localPosition.x < 0f ? -1f : 1f;
        var x = offsetX * multiplier;
        transform.localPosition = new Vector3(x, y: transform.localPosition.y, z: transform.localPosition.z);
    }
}