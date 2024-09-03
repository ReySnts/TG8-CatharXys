using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractArray2D<NodePath>))]

public sealed class ResetterNodePath : AbstractResetter
{
    private AbstractArray2D<NodePath> array2DNodePath;

    protected override void Awake() => array2DNodePath = GetComponent<AbstractArray2D<NodePath>>();

    public override void DoReset()
    {
        var array2DNodePath = this.array2DNodePath.Array;
        var width = array2DNodePath.GetLength(dimension: 0);
        var height = array2DNodePath.GetLength(dimension: 1);
        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                var nodePath = array2DNodePath[x, y];
                nodePath.CostG = int.MaxValue;
                nodePath.CalculateTotalCost();
                nodePath.NodePathPrevious = null;
            }
        }
    }
}