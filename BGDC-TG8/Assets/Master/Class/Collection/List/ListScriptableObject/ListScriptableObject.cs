using System.Linq;
using UnityEngine;

public abstract class ListScriptableObject<TScriptableObject> : AbstractList<TScriptableObject> where TScriptableObject : ScriptableObject
{
    protected abstract string SpecificPath {  get; }

    protected override void Awake() => list = Resources.LoadAll<TScriptableObject>(path: FilePath.SCRIPTABLE_OBJECT + SpecificPath).ToList();
}