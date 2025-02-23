public sealed class ListDirectionType : AbstractList<DirectionType>
{
    protected override void Awake()
    {
        list.Add(item: DirectionType.South);
        list.Add(item: DirectionType.SouthEast);
        list.Add(item: DirectionType.East);
        list.Add(item: DirectionType.NorthEast);
        list.Add(item: DirectionType.North);
        list.Add(item: DirectionType.NorthWest);
        list.Add(item: DirectionType.West);
        list.Add(item: DirectionType.SouthWest);
    }
}