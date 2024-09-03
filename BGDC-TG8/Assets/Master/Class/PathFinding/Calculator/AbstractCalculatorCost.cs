using UnityEngine;

public abstract class AbstractCalculatorCost<TReturn> : MonoBehaviour
{
    public abstract TReturn DoCalculate(AbstractNode nodeOrigin, AbstractNode nodeDestination);
}