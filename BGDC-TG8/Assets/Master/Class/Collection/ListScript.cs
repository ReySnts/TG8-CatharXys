using System.Collections.Generic;
using UnityEngine;

public abstract class ListScript<T> : MonoBehaviour, IList<T>
{
    protected List<T> list = new List<T>();

    public List<T> List => list;

    protected abstract void Awake();

    protected void OnDestroy() => list.Clear();
}