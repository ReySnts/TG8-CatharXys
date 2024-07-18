using UnityEngine;

public class ButtonFactory : MonoBehaviour, IFactory<IButton>
{
    [SerializeField] private GameObject button;

    public IProduct<IButton> GetProduct(IButton iButton)
    {
        var instance = Instantiate(original: button, parent: transform);
        var newProduct = instance.GetComponent<IProduct<IButton>>();
        newProduct.Initialize(parameter: iButton);
        return newProduct;
    }
}