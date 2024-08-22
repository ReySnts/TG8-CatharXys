using UnityEngine;

public abstract class AbstractFactory<TProduct> : MonoBehaviour
{
    [SerializeField] protected GameObject original;

    public virtual AbstractProduct<TProduct> GetProduct(TProduct product, Transform parent)
    {
        var instance = Instantiate(original, parent);
        var newProduct = instance.GetComponent<AbstractProduct<TProduct>>();
        newProduct.Initialize(product);
        return newProduct;
    }
}