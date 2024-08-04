using UnityEngine;

public abstract class LayoutGroupList<TItem> : MonoBehaviour
{
    private void Awake()
    {
        var abstractFactory = GetComponent<AbstractFactory<TItem>>();
        var abstractList = GetComponentInParent<AbstractList<TItem>>();
        abstractList.List.ForEach(action: item => abstractFactory.GetProduct(product: item));
    }
}