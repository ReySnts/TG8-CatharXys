using UnityEngine;

public sealed class WalkPlayer : AbstractMovementPlayer
{
    private void Update() => direction = new Vector2(x: playableScene.InputManager.AxisRawHorizontal, y: playableScene.InputManager.AxisRawVertical).normalized;

    private void FixedUpdate() => character.Rigidbody2D.velocity = direction * speed;
}