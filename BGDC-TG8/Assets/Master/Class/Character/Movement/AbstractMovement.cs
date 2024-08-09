using UnityEngine;

public abstract class AbstractMovement : MonoBehaviour
{
    [SerializeField] protected float speed;

    protected AbstractCharacter character;

    protected Vector2 direction;

    protected virtual void Awake() => character = GetComponentInParent<AbstractCharacter>();
}