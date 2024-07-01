public sealed class ListDirectionType : ListScript<DirectionType>, IList<DirectionType>
{
    protected override void Awake()
    {
        list.Add(DirectionType.North);
        list.Add(DirectionType.NorthWest);
        list.Add(DirectionType.West);
        list.Add(DirectionType.SouthWest);
        list.Add(DirectionType.South);
        list.Add(DirectionType.SouthEast);
        list.Add(DirectionType.East);
        list.Add(DirectionType.NorthEast);
    }
}