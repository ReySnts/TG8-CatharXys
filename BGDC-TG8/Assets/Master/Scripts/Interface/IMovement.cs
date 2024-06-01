using UnityEngine;

public interface IMovement
{
    public abstract IAnimationDirection Animation { get; }

    public abstract Vector2 Direction { get; }
}