using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractArray2D<TextMesh>), requiredComponent2: typeof(AbstractFactory<Vector3>))]

public abstract class AbstractGrid<TValue> : MonoBehaviour where TValue : MonoBehaviour
{
    [SerializeField] protected int width;

    [SerializeField] protected int height;

    [SerializeField] protected int edgeLength;

    protected AbstractArray2D<TValue> values;

    protected AbstractArray2D<TextMesh> texts;

    protected AbstractFactory<Vector3> vertexFactory;

    private void Awake()
    {
        values = GetComponent<AbstractArray2D<TValue>>();
        texts = GetComponent<AbstractArray2D<TextMesh>>();
        vertexFactory = GetComponent<AbstractFactory<Vector3>>();
        DrawVertices();
        DrawLinePeek();
    }

    protected abstract void DrawVertices();

    public Vector3 GetWorldPosition(int x, int y) => new Vector3(x, y) * edgeLength;

    protected void DrawLine(Vector3 start, Vector3 end)
    {
        var color = Color.white;
        Debug.DrawLine(start, end, color);
    }

    private void DrawLinePeek()
    {
        var peekPosition = GetWorldPosition(x: width, y: height);
        DrawLine(start: GetWorldPosition(x: 0, y: height), end: peekPosition);
        DrawLine(start: GetWorldPosition(x: width, y: 0), end: peekPosition);
    }
}