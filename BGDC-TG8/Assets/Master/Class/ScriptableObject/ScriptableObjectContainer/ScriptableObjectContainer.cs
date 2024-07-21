using UnityEngine;

public abstract class ScriptableObjectContainer<TScriptableObject> : MonoBehaviour where TScriptableObject : ScriptableObject
{
    [SerializeField] protected TScriptableObject scriptableObject;

    public TScriptableObject ScriptableObject { get => scriptableObject; set => scriptableObject = value; }
}