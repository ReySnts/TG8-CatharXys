using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractWeapon))]

public sealed class BulletFactory : AbstractFactory<Vector2>
{
    private AbstractWeapon weapon;

    private void Awake() => weapon = GetComponent<AbstractWeapon>();

    public override AbstractProduct<Vector2> GetProduct(Vector2 mousePointerClickPosition, Transform parent)
    {
        var instance = Instantiate(original, position: weapon.Positioner.transform.position, rotation: weapon.Rotator.transform.rotation, parent);
        var newProduct = instance.GetComponent<AbstractProduct<Vector2>>();
        newProduct.Initialize(product: mousePointerClickPosition);
        return newProduct;
    }
}