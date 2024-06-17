using UnityEngine;

public interface IListScriptableObject<TScriptableObject> : IList<TScriptableObject> where TScriptableObject : ScriptableObject { }