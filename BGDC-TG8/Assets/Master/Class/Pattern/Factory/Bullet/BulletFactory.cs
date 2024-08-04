using UnityEngine;

public sealed class BulletFactory : AbstractFactory<Vector2>
{
    public override IProduct<Vector2> GetProduct(Vector2 mousePointerClickPosition)
    {
        var weapon = GetComponentInParent<AbstractWeapon>();
        var instance = Instantiate(original, position: transform.position, rotation: Quaternion.identity, parent: weapon.transform);
        var newProduct = instance.GetComponent<IProduct<Vector2>>();
        newProduct.Initialize(parameter: mousePointerClickPosition);
        return newProduct;
    }
}