using UnityEngine;

public class BulletFactory : MonoBehaviour, IFactory<Vector2>
{
    [SerializeField] private GameObject bullet;

    public IProduct<Vector2> GetProduct(Vector2 mousePointerClickPosition)
    {
        var instance = Instantiate(original: bullet, parent: transform);
        var newProduct = instance.GetComponent<BulletProduct>();
        newProduct.Initialize(mousePointerClickPosition);
        return newProduct;
    }
}