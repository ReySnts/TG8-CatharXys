using UnityEngine;

public class ListStateDirection : ListScript<string>
{
    [SerializeField] private StateType stateType;

    protected override void Awake()
    {
        var directionTypeList = GetComponentInParent<IList<DirectionType>>().List;
        foreach (var directionType in directionTypeList) list.Add(directionType.ToString() + "_" + stateType.ToString());
    }
}