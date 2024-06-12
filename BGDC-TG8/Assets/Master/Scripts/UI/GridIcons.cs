using UnityEngine;

public class GridIcons : MonoBehaviour
{
    private void Awake()
    {
        var iFactory = GetComponent<IFactory<int>>();
        var iList = GetComponentInParent<IListScriptableObjectBoss>();
        var listCount = iList.List.Count;
        for (int index = 0; index < listCount; index++) iFactory.GetProduct(index);
    }
}