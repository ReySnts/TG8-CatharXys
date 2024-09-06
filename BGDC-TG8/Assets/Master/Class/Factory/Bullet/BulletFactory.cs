using UnityEngine;

public class BulletFactory : MonoBehaviour, IFactory<Vector2>
{
    [SerializeField] private GameObject bullet;

    public IProduct<Vector2> GetProduct(Vector2 mousePointerClickPosition)
    {
        var iWeapon = GetComponentInParent<IWeapon>();
        var instance = Instantiate(original: bullet, position: transform.position, rotation: Quaternion.identity, parent: iWeapon.GameObject.transform);
        var newProduct = instance.GetComponent<BulletProduct>();
        newProduct.Initialize(mousePointerClickPosition);
        return newProduct;
    }
}