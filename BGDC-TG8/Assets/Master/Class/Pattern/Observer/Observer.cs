using UnityEngine;
using UnityEngine.Events;

public abstract class Observer<T> : MonoBehaviour
{
    public event UnityAction<T> OnAllNotified;

    public void NotifyAllToChange(T t) => OnAllNotified.Invoke(t);
}

public abstract class Observer : MonoBehaviour
{
    public event UnityAction OnAllNotified;

    public void NotifyAllToChange() => OnAllNotified.Invoke();
}