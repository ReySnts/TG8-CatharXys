using UnityEngine.Events;

public interface IObserver<T>
{
    public abstract event UnityAction<T> OnAllNotified;

    public abstract void NotifyAllToChange(T t);
}

public interface IObserver
{
    public abstract event UnityAction OnAllNotified;

    public abstract void NotifyAllToChange();
}