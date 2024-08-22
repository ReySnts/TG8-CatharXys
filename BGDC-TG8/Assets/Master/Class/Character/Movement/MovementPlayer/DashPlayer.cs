using UnityEngine;

public sealed class DashPlayer : AbstractMovementPlayer
{
    [SerializeField] private LayerMask layerMask;

    private bool keyDownLeftShift;

    private void Update()
    {
        var inputManager = playableScene.InputManager;
        direction = new Vector2(x: inputManager.AxisRawHorizontal, y: inputManager.AxisRawVertical).normalized;
        keyDownLeftShift = inputManager.KeyDownLeftShift;
    }

    private void FixedUpdate()
    {
        if (keyDownLeftShift)
        {
            var targetPosition = (Vector2)transform.position + direction * speed;
            var raycastHit2D = Physics2D.Raycast(origin: transform.position, direction, distance: speed, layerMask);
            var position = raycastHit2D.collider ? raycastHit2D.point : targetPosition;
            character.Rigidbody2D.MovePosition(position);
        }
    }
}