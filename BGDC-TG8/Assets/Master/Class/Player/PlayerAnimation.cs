using UnityEngine;

public class PlayerAnimation : MonoBehaviour, IAnimationDirection
{
    public Animator Animator { get; private set; }

    public int LastDirectionIndex { get; set; }

    private void Awake() => Animator = GetComponent<Animator>();

    public int IndexOf(Vector2 direction)
    {
        var angle = Vector2.SignedAngle(from: Vector2.up, to: direction.normalized);
        var step = 45f;
        angle += (step / 2f);
        if (angle < 0f) angle += 360f;
        return Mathf.FloorToInt(f: angle / step);
    }
}