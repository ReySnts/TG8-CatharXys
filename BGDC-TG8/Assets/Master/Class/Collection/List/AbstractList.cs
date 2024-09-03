using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractList<T> : MonoBehaviour
{
    protected List<T> list = new List<T>();

    public List<T> List { get => list; set => list = value; }

    protected abstract void Awake();

    private void OnDestroy() => list.Clear();
}