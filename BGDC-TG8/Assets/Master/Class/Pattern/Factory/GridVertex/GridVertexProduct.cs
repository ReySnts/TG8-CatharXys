using UnityEngine;

public sealed class GridVertexProduct : AbstractProduct<Vector3>
{
    public override void Initialize(Vector3 localPosition) => transform.localPosition = localPosition;
}