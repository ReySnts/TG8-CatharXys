using UnityEngine;

[RequireComponent(typeof(IFactory<IScriptableObjectBoss>))]

public sealed class GridIcons : MonoBehaviour
{
    private void Awake()
    {
        var iFactory = GetComponent<IFactory<IScriptableObjectBoss>>();
        var iList = GetComponentInParent<IListScriptableObjectBoss>();
        foreach (var item in iList.List) iFactory.GetProduct(parameter: item);
    }
}