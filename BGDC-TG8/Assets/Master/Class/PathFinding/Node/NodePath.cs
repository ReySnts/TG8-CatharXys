public sealed class NodePath : AbstractNode
{
    public NodePath NodePathPrevious { get; set; }

    public int CostG { get; set; }

    public int CostH { get; set; }

    public int CostF { get; private set; }

    public void CalculateTotalCost() => CostF = CostG + CostH;
}