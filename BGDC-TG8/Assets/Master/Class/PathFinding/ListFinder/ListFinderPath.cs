using System.Collections.Generic;
using System.Linq;

public sealed class ListFinderPath : AbstractListFinder
{
    public override List<NodePath> DoFind(int xDestination, int yDestination)
    {
        var listClosed = this.listClosed.List;
        var listOpen = this.listOpen.List;
        var nodeDestination = array2DNodePath.Array[xDestination, yDestination];
        while (listOpen.Count > 0)
        {
            var nodeNext = listOpen.OrderBy(keySelector: nodePath => nodePath.CostF).FirstOrDefault();
            if (nodeNext == nodeDestination) return listNodePath.ListAllNodesWith(node: nodeDestination);
            else
            {
                listOpen.Remove(item: nodeNext);
                listClosed.Add(item: nodeNext);
                var listNeighbour = listNodeNeighbour.ListAllNodesWith(node: nodeNext);
                foreach (var nodeNeighbour in listNeighbour)
                {
                    if (!listClosed.Contains(item: nodeNeighbour))
                    {
                        var costGTentative = nodeNext.CostG + calculatorCostHeuristic.DoCalculate(nodeNext, nodeNeighbour);
                        if (costGTentative < nodeNeighbour.CostG)
                        {
                            nodeNeighbour.NodePathPrevious = nodeNext;
                            nodeNeighbour.CostG = costGTentative;
                            nodeNeighbour.CostH = calculatorCostHeuristic.DoCalculate(nodeNeighbour, nodeDestination);
                            nodeNeighbour.CalculateTotalCost();
                            if (!listOpen.Contains(item: nodeNeighbour)) listOpen.Add(item: nodeNeighbour);
                        }
                    }
                }
            }
        }
        return null;
    }
}