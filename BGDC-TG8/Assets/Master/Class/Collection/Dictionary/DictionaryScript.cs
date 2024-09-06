using System.Collections.Generic;
using UnityEngine;

public abstract class DictionaryScript<TKey, TValue> : MonoBehaviour
{
    protected Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

    public Dictionary<TKey, TValue> Dictionary => dictionary;

    protected abstract void Awake();

    protected void OnDestroy() => dictionary.Clear();
}