using UnityEngine;

public sealed class ListStateDirection : ListScript<string>
{
    [SerializeField] private StateType stateType;

    protected override void Awake()
    {
        var directionTypeList = GetComponentInParent<ListScript<DirectionType>>().List;
        directionTypeList.ForEach(action: directionType => list.Add(item: directionType.ToString() + "_" + stateType.ToString()));
    }
}