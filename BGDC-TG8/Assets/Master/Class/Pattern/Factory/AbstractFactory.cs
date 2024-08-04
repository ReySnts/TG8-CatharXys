using UnityEngine;

public abstract class AbstractFactory<TProduct> : MonoBehaviour
{
    [SerializeField] protected GameObject original;

    public virtual IProduct<TProduct> GetProduct(TProduct product)
    {
        var instance = Instantiate(original, parent: transform);
        var newProduct = instance.GetComponent<IProduct<TProduct>>();
        newProduct.Initialize(parameter: product);
        return newProduct;
    }
}