using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractWeapon))]

public sealed class BulletFactory : AbstractFactory<Vector2>
{
    private AbstractWeapon weapon;

    private void Awake() => weapon = GetComponent<AbstractWeapon>();

    public override IProduct<Vector2> GetProduct(Vector2 mousePointerClickPosition, Transform parent)
    {
        var instance = Instantiate(original, position: weapon.Positioner.transform.position, rotation: weapon.Rotator.transform.rotation, parent);
        var newProduct = instance.GetComponent<IProduct<Vector2>>();
        newProduct.Initialize(parameter: mousePointerClickPosition);
        return newProduct;
    }
}