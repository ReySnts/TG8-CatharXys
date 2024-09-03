using UnityEngine;

public abstract class AbstractResetter : MonoBehaviour
{
    protected abstract void Awake();

    public abstract void DoReset();
}