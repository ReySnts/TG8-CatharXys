using System.Collections.Generic;

public sealed class ListNodePath : AbstractListNode<NodePath>
{
    public override List<NodePath> ListAllNodesWith(NodePath nodeDestination)
    {
        var listPath = new List<NodePath>();
        var nodeCurrent = nodeDestination;
        listPath.Add(item: nodeDestination);
        while (nodeCurrent.NodePathPrevious != null)
        {
            listPath.Add(item: nodeCurrent.NodePathPrevious);
            nodeCurrent = nodeCurrent.NodePathPrevious;
        }
        listPath.Reverse();
        return listPath;
    }
}