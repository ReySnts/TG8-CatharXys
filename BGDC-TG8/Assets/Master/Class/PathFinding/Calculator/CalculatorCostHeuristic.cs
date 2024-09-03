using UnityEngine;

public sealed class CalculatorCostHeuristic : AbstractCalculatorCost<int>
{
    [SerializeField] private int costGDiagonal = 14;

    [SerializeField] private int costGStraight = 10;

    public override int DoCalculate(AbstractNode nodeOrigin, AbstractNode nodeDestination)
    {
        var distanceX = Mathf.Abs(f: nodeOrigin.CoordinateX - nodeDestination.CoordinateX);
        var distanceY = Mathf.Abs(f: nodeOrigin.CoordinateY - nodeDestination.CoordinateY);
        var distanceDifference = (int)Mathf.Abs(f: distanceX - distanceY);
        var distanceMinimum = (int)Mathf.Min(a: distanceX, b: distanceY);
        var heuristicCost = costGDiagonal * distanceMinimum + costGStraight * distanceDifference;
        return heuristicCost;
    }
}