using UnityEngine.Events;

public interface IObserver<T>
{
    public abstract event UnityAction<T> OnAllNotified;

    public abstract void NotifyAllToChange(T t);
}