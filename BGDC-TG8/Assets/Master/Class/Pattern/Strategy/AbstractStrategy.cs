using UnityEngine;

public abstract class AbstractStrategy<T> : MonoBehaviour
{
    [SerializeField] protected T strategy;

    public virtual void SetStrategy(T strategy) => this.strategy = strategy;
}