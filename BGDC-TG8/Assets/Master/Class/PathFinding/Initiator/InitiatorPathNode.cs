using System.Collections.Generic;

public sealed class InitiatorPathNode : AbstractInitiatorPath
{
    public override void DoInitiate(int xOrigin, int yOrigin, int xDestination, int yDestination)
    {
        var array2DNodePath = this.array2DNodePath.Array;
        var nodeOrigin = array2DNodePath[xOrigin, yOrigin];
        var nodeDestination = array2DNodePath[xDestination, yDestination];
        nodeOrigin.CostG = 0;
        nodeOrigin.CostH = calculatorCostHeuristic.DoCalculate(nodeOrigin, nodeDestination);
        nodeOrigin.CalculateTotalCost();
        listOpen.List = new List<NodePath>() { nodeOrigin };
        listClosed.List = new List<NodePath>();
    }
}