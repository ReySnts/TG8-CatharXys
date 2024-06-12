using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class ListScriptableObject<TScriptableObject> : MonoBehaviour, IListScriptableObject<TScriptableObject> where TScriptableObject : ScriptableObject
{
    protected abstract string SpecificPath {  get; }

    private List<TScriptableObject> list = new List<TScriptableObject>();

    public List<TScriptableObject> List => list;

    private void Awake() => list = Resources.LoadAll<TScriptableObject>(path: FilePath.SCRIPTABLE_OBJECT + SpecificPath).ToList();
}