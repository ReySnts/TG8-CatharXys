using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour, IMovement
{
    [FormerlySerializedAs(oldName: FirstVariableName.MOVE_SPEED), SerializeField] private float moveSpeed;

    public Vector2 Direction { get; private set; } = Vector2.zero;

    private IPlayer player;

    private Rigidbody2D rigidBody2D;

    private void Awake()
    {
        player = GetComponentInParent<IPlayer>();
        rigidBody2D = GetComponentInParent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var playerInput = player.Input;
        rigidBody2D.velocity = new Vector2(x: playerInput.AxisRawHorizontal, y: playerInput.AxisRawVertical) * moveSpeed;
        Direction = rigidBody2D.velocity;
    }
}