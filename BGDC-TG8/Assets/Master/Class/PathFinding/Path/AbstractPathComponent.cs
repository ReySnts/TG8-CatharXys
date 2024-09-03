using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractArray2D<NodePath>), requiredComponent2: typeof(AbstractCalculatorCost<int>))]
[RequireComponent(requiredComponent: typeof(ListPathFinderClosed), requiredComponent2: typeof(ListPathFinderOpen))]

public abstract class AbstractPathComponent : MonoBehaviour
{
    protected AbstractArray2D<NodePath> array2DNodePath;

    protected AbstractCalculatorCost<int> calculatorCostHeuristic;

    protected AbstractList<NodePath> listClosed;

    protected AbstractList<NodePath> listOpen;

    protected virtual void Awake()
    {
        array2DNodePath = GetComponent<AbstractArray2D<NodePath>>();
        calculatorCostHeuristic = GetComponent<AbstractCalculatorCost<int>>();
        listClosed = GetComponent<ListPathFinderClosed>();
        listOpen = GetComponent<ListPathFinderOpen>();
    }
}