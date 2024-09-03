using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractListNode<TNode> : MonoBehaviour
{
    public abstract List<NodePath> ListAllNodesWith(TNode node);
}