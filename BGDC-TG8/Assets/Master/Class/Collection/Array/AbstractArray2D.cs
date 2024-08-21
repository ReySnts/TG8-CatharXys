using UnityEngine;

public abstract class AbstractArray2D<T> : MonoBehaviour
{
    [SerializeField] private int width;

    [SerializeField] private int height;

    protected T[,] array;

    public T[,] Array { get => array; set => array = value; }

    private void Awake() => array = new T[width, height];

    private void OnDestroy()
    {
        for (int row = 0; row < width; row++)
            for (int column = 0; column < height; column++)
                Destroy(obj: array[row, column] as Object);
    }
}