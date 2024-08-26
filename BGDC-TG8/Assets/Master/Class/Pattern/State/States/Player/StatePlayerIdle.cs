using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractAnimationPlayer))]

public sealed class StatePlayerIdle : AbstractStatePlayer
{
    [SerializeField] private AbstractState walk;

    public override void Enter()
    {
        contextAnimationPlayer.SetStrategy(strategy: GetComponent<AnimationPlayerIdle>());
        contextSoundPlayer.SetStrategy(strategy: null);
    }

    public override void DoUpdate()
    {
        var inputManager = playableScene.InputManager;
        var direction = new Vector2(x: inputManager.AxisRawHorizontal, y: inputManager.AxisRawVertical).normalized;
        if (direction.magnitude > 0f) stateMachine.TransitionTo(nextState: walk);
    }
}