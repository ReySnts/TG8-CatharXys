using System.Collections.Generic;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(ListNodeNeighbour), requiredComponent2: typeof(ListNodePath))]

public abstract class AbstractListFinder : AbstractPathComponent
{
    protected AbstractListNode<AbstractNode> listNodeNeighbour;

    protected AbstractListNode<NodePath> listNodePath;

    protected override void Awake()
    {
        base.Awake();
        listNodeNeighbour = GetComponent<ListNodeNeighbour>();
        listNodePath = GetComponent<ListNodePath>();
    }

    public abstract List<NodePath> DoFind(int xDestination, int yDestination);
}