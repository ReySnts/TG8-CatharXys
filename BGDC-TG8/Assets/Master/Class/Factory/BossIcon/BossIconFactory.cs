using UnityEngine;

public class BossIconFactory : MonoBehaviour, IFactory<int>
{
    [SerializeField] private GameObject imageIcon;

    public IProduct<int> GetProduct(int index)
    {
        var instance = Instantiate(original: imageIcon, parent: transform);
        var newProduct = instance.GetComponent<IProduct<int>>();
        newProduct.Initialize(index);
        return newProduct;
    }
}