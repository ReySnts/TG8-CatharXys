using UnityEngine;
using UnityEngine.Events;

public abstract class Observer<T> : MonoBehaviour, IObserver<T>
{
    public event UnityAction<T> OnAllNotified;

    public void NotifyAllToChange(T t) => OnAllNotified.Invoke(t);
}