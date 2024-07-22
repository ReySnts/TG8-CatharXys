using UnityEngine;

public abstract class FactoryScript<TProduct> : MonoBehaviour, IFactory<TProduct>
{
    [SerializeField] private GameObject original;

    public IProduct<TProduct> GetProduct(TProduct product)
    {
        var instance = Instantiate(original, parent: transform);
        var newProduct = instance.GetComponent<IProduct<TProduct>>();
        newProduct.Initialize(parameter: product);
        return newProduct;
    }
}