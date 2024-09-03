using System.Collections.Generic;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractArray2D<NodePath>))]

public sealed class ListNodeNeighbour : AbstractListNode<AbstractNode>
{
    private AbstractArray2D<NodePath> array2DNodePath;

    private void Awake() => array2DNodePath = GetComponent<AbstractArray2D<NodePath>>();

    public override List<NodePath> ListAllNodesWith(AbstractNode node)
    {
        var array2DNodePath = this.array2DNodePath.Array;
        var listNeighbour = new List<NodePath>();
        var nodeDown = node.CoordinateY - 1;
        var nodeLeft = node.CoordinateX - 1;
        var nodeRight = node.CoordinateX + 1;
        var nodeX = node.CoordinateX;
        var nodeUp = node.CoordinateY + 1;
        var nodeY = node.CoordinateY;
        var width = array2DNodePath.GetLength(dimension: 0);
        var height = array2DNodePath.GetLength(dimension: 1);
        if (nodeLeft >= 0)
        {
            listNeighbour.Add(item: array2DNodePath[nodeLeft, nodeY]);
            if (nodeDown >= 0) listNeighbour.Add(item: array2DNodePath[nodeLeft, nodeDown]);
            if (nodeUp < height) listNeighbour.Add(item: array2DNodePath[nodeLeft, nodeUp]);
        }
        if (nodeRight < width)
        {
            listNeighbour.Add(item: array2DNodePath[nodeRight, nodeY]);
            if (nodeDown >= 0) listNeighbour.Add(item: array2DNodePath[nodeRight, nodeDown]);
            if (nodeUp < height) listNeighbour.Add(item: array2DNodePath[nodeRight, nodeUp]);
        }
        if (nodeDown >= 0) listNeighbour.Add(item: array2DNodePath[nodeX, nodeDown]);
        if (nodeUp < height) listNeighbour.Add(item: array2DNodePath[nodeX, nodeUp]);
        return listNeighbour;
    }
}