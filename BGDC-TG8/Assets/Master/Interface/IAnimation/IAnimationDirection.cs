using UnityEngine;

public interface IAnimationDirection : IAnimation, IIndexer<int, Vector2>
{
    public abstract int LastDirectionIndex { get; set; }
}