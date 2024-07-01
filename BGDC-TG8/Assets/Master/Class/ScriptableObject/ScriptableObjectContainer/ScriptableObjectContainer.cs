using UnityEngine;

public abstract class ScriptableObjectContainer<TScriptableObject> : MonoBehaviour, IScriptableObjectContainer<TScriptableObject> where TScriptableObject : IScriptableObject
{
    [SerializeField] protected TScriptableObject scriptableObjectScript;

    public TScriptableObject IScriptableObject { get => scriptableObjectScript; set => scriptableObjectScript = value; }
}