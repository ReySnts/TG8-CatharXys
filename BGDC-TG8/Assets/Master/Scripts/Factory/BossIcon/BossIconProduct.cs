using UnityEngine;
using UnityEngine.UI;

public class BossIconProduct : MonoBehaviour, IProduct<int>, IIndexable
{
    [field: SerializeField] public int Index { get; set; }

    public void Initialize(int index)
    {
        Index = index;
        GetComponent<Image>().sprite = GetComponentInParent<IListScriptableObjectBoss>().List[index].IconImage;
    }
}