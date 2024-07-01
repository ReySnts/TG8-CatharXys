public interface IScriptableObjectContainer<TScriptableObject> where TScriptableObject : IScriptableObject
{
    public abstract TScriptableObject IScriptableObject { get; set; }
}