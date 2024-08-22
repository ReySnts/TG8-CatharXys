using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractAnimationPlayer))]

public sealed class StatePlayerWalk : AbstractStatePlayer
{
    [SerializeField] private AbstractState idle;

    public override void Enter() => contextAnimationPlayer.SetStrategy(strategy: GetComponent<AnimationPlayerWalk>());

    public override void DoUpdate()
    {
        var inputManager = playableScene.InputManager;
        var direction = new Vector2(x: inputManager.AxisRawHorizontal, y: inputManager.AxisRawVertical).normalized;
        if (direction.magnitude <= 0f) stateMachine.TransitionTo(nextState: idle);
    }
}