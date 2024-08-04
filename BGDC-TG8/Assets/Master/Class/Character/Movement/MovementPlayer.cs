using UnityEngine;

public sealed class MovementPlayer : AbstractMovement
{
    private AbstractScenePlayable playableScene;

    private Vector2 direction;

    private void Awake() => playableScene = GetComponentInParent<AbstractScenePlayable>();

    private void Update() => direction = new Vector2(x: playableScene.InputManager.AxisRawHorizontal, y: playableScene.InputManager.AxisRawVertical).normalized;

    private void FixedUpdate() => playableScene.Player.Rigidbody2D.velocity = direction * speed;
}