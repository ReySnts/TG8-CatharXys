using System.Collections.Generic;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractGrid<NodePath>), requiredComponent2: typeof(AbstractInitiatorPath))]
[RequireComponent(requiredComponent: typeof(AbstractListFinder), requiredComponent2: typeof(AbstractResetter))]

public sealed class PathFinder : MonoBehaviour
{
    private AbstractGrid<NodePath> gridNodePath;

    private AbstractInitiatorPath initiatorPathNode;

    private AbstractListFinder listFinderPath;

    private AbstractResetter resetterAllNodes;

    private void Awake()
    {
        gridNodePath = GetComponent<AbstractGrid<NodePath>>();
        initiatorPathNode = GetComponent<AbstractInitiatorPath>();
        listFinderPath = GetComponent<AbstractListFinder>();
        resetterAllNodes = GetComponent<AbstractResetter>();
    }

    private void Update()
    {
        var path = FindPath(9, 9, 1, 2);
        var pathCount = path.Count;
        if (path != null)
        {
            for (var i = 0; i < pathCount - 1; i++)
            {
                var start = gridNodePath.GetWorldPosition(x: path[i].CoordinateX, y: path[i].CoordinateY);
                var end = gridNodePath.GetWorldPosition(x: path[i + 1].CoordinateX, y: path[i + 1].CoordinateY);
                Debug.DrawLine(start: start + Vector3.one * 1f, end: end + Vector3.one * 1f);
            }
        }
    }

    private List<NodePath> FindPath(int xOrigin, int yOrigin, int xDestination, int yDestination)
    {
        resetterAllNodes.DoReset();
        initiatorPathNode.DoInitiate(xOrigin, yOrigin, xDestination, yDestination);
        return listFinderPath.DoFind(xDestination, yDestination);
    }
}