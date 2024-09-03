using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractArray2D<NodePath>))]

public sealed class GridNodePath : AbstractGrid<NodePath>
{
    protected override void DrawVertices()
    {
        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                var localPosition = GetWorldPosition(x, y);
                var vertex = vertexFactory.GetProduct(product: localPosition + new Vector3(x: edgeLength, y: edgeLength) * .5f, parent: transform);
                values.Array[x, y] = vertex.gameObject.AddComponent<NodePath>();
                values.Array[x, y].CoordinateX = x;
                values.Array[x, y].CoordinateY = y;
                texts.Array[x, y] = vertex.GetComponent<TextMesh>();
                texts.Array[x, y].text = x + "," + y;
                DrawLine(start: localPosition, end: GetWorldPosition(x, y + 1));
                DrawLine(start: localPosition, end: GetWorldPosition(x + 1, y));
            }
        }
    }
}