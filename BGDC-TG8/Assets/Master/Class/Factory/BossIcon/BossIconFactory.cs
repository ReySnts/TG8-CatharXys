using UnityEngine;

public sealed class BossIconFactory : MonoBehaviour, IFactory<IScriptableObjectBoss>
{
    [SerializeField] private GameObject imageIcon;

    public IProduct<IScriptableObjectBoss> GetProduct(IScriptableObjectBoss iScriptableObjectBoss)
    {
        var instance = Instantiate(original: imageIcon, parent: transform);
        var newProduct = instance.GetComponent<IProduct<IScriptableObjectBoss>>();
        newProduct.Initialize(iScriptableObjectBoss);
        return newProduct;
    }
}