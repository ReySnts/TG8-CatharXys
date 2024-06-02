using System.Collections.Generic;
using UnityEngine;

public class ListStateDirection : MonoBehaviour, IList<string>
{
    [SerializeField] private StateType stateType;

    private readonly List<string> list = new List<string>();

    public List<string> List => list;

    private void Awake()
    {
        var underScoreStateType = "_" + stateType.ToString();
        list.Add(DirectionType.North.ToString() + underScoreStateType);
        list.Add(DirectionType.NorthWest.ToString() + underScoreStateType);
        list.Add(DirectionType.West.ToString() + underScoreStateType);
        list.Add(DirectionType.SouthWest.ToString() + underScoreStateType);
        list.Add(DirectionType.South.ToString() + underScoreStateType);
        list.Add(DirectionType.SouthEast.ToString() + underScoreStateType);
        list.Add(DirectionType.East.ToString() + underScoreStateType);
        list.Add(DirectionType.NorthEast.ToString() + underScoreStateType);
    }

    private void OnDestroy() => list.Clear();
}