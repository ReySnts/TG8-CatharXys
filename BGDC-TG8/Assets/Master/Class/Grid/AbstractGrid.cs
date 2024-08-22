using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractArray2D<TextMesh>), requiredComponent2: typeof(AbstractFactory<Vector3>))]

public abstract class AbstractGrid<TValue> : MonoBehaviour
{
    [SerializeField] private int width;

    [SerializeField] private int height;

    [SerializeField] private int edgeLength;

    private AbstractArray2D<TValue> values;

    private AbstractArray2D<TextMesh> texts;

    private AbstractFactory<Vector3> vertexFactory;

    private void Awake()
    {
        values = GetComponent<AbstractArray2D<TValue>>();
        texts = GetComponent<AbstractArray2D<TextMesh>>();
        vertexFactory = GetComponent<AbstractFactory<Vector3>>();
        DrawVertices();
        DrawLinePeek();
    }

    private void DrawVertices()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var localPosition = GetWorldPosition(x, y);
                var vertex = vertexFactory.GetProduct(product: localPosition + new Vector3(x: edgeLength, y: edgeLength) * .5f, parent: transform);
                texts.Array[x, y] = vertex.GetComponent<TextMesh>();
                DrawLine(start: localPosition, end: GetWorldPosition(x, y + 1));
                DrawLine(start: localPosition, end: GetWorldPosition(x + 1, y));
            }
        }
    }

    private Vector3 GetWorldPosition(int x, int y) => new Vector3(x, y) * edgeLength;

    private void DrawLine(Vector3 start, Vector3 end)
    {
        var color = Color.white;
        var duration = 100000f;
        Debug.DrawLine(start, end, color, duration);
    }

    private void DrawLinePeek()
    {
        var peekPosition = GetWorldPosition(x: width, y: height);
        DrawLine(start: GetWorldPosition(x: 0, y: height), end: peekPosition);
        DrawLine(start: GetWorldPosition(x: width, y: 0), end: peekPosition);
    }

    public void SetValue(int x, int y, TValue value)
    {
        values.Array[x, y] = value;
        texts.Array[x, y].text = value.ToString();
    }
}