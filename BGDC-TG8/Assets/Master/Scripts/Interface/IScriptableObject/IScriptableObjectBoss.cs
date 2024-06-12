using UnityEngine;

public interface IScriptableObjectBoss : IScriptableObject
{
    public abstract string Name { get; }

    public abstract string Description { get; }

    public abstract Sprite IconImage { get; }

    public abstract Sprite DisplayImage { get; }
}