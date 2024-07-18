using UnityEngine;

[RequireComponent(typeof(IFactory<IButton>))]

public sealed class GridButtons : MonoBehaviour
{
    private void Awake()
    {
        var iFactory = GetComponent<IFactory<IButton>>();
        var iList = GetComponentInParent<IList<IButton>>();
        foreach (var item in iList.List) iFactory.GetProduct(parameter: item);
    }
}