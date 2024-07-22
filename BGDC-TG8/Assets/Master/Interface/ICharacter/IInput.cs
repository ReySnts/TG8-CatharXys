using UnityEngine;

public interface IInput
{
    public abstract float AxisRawHorizontal { get; }

    public abstract float AxisRawVertical { get; }

    public abstract bool LeftMouseButtonDown { get; }

    public abstract Vector3 MousePosition { get; }
}