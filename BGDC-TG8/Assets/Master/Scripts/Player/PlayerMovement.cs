using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour, IMovement
{
    [FormerlySerializedAs(oldName: FirstVariableName.MOVE_SPEED), SerializeField] private float moveSpeed;

    public IAnimationDirection Animation { get; private set; }

    public Vector2 Direction { get; private set; } = Vector2.zero;

    private Rigidbody2D rigidBody2D;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        Animation = GetComponentInChildren<IAnimationDirection>();
    }

    private void Update()
    {
        var moveHorizontal = Input.GetAxisRaw("Horizontal") * moveSpeed;
        var moveVertical = Input.GetAxisRaw("Vertical") * moveSpeed;
        Direction = new Vector2(moveHorizontal, moveVertical);
        rigidBody2D.velocity = Direction;
    }
}