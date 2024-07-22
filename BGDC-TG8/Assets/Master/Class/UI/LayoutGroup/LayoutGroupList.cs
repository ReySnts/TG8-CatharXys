using UnityEngine;

public abstract class LayoutGroupList<TItem> : MonoBehaviour
{
    private void Awake()
    {
        var abstractFactory = GetComponent<IFactory<TItem>>();
        var abstractList = GetComponentInParent<ListScript<TItem>>();
        abstractList.List.ForEach(action: item => abstractFactory.GetProduct(parameter: item));
    }
}