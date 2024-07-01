using System.Linq;
using UnityEngine;

public abstract class ListScriptableObject<TScriptableObject> : ListScript<TScriptableObject>, IListScriptableObject<TScriptableObject> where TScriptableObject : ScriptableObjectScript
{
    protected abstract string SpecificPath {  get; }

    protected override void Awake() => list = Resources.LoadAll<TScriptableObject>(path: FilePath.SCRIPTABLE_OBJECT + SpecificPath).ToList();
}