using UnityEngine;

public sealed class ListStateDirection : AbstractList<string>
{
    [SerializeField] private StateType stateType;

    protected override void Awake()
    {
        var directionTypeList = GetComponentInParent<AbstractList<DirectionType>>().List;
        directionTypeList.ForEach(action: directionType => list.Add(item: directionType.ToString() + "_" + stateType.ToString()));
    }
}