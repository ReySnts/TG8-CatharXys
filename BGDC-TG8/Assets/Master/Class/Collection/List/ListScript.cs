using System.Collections.Generic;
using UnityEngine;

public abstract class ListScript<T> : MonoBehaviour
{
    protected List<T> list = new List<T>();

    public List<T> List => list;

    protected abstract void Awake();

    private void OnDestroy() => list.Clear();
}