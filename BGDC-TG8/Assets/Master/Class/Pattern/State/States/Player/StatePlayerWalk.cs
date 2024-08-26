using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractAnimationPlayer), requiredComponent2: typeof(AbstractAudioClip))]

public sealed class StatePlayerWalk : AbstractStatePlayer
{
    [SerializeField] private AbstractState idle;

    public override void Enter()
    {
        contextAnimationPlayer.SetStrategy(strategy: GetComponent<AnimationPlayerWalk>());
        contextSoundPlayer.SetStrategy(strategy: GetComponent<AbstractAudioClip>());
    }

    public override void DoUpdate()
    {
        var inputManager = playableScene.InputManager;
        var direction = new Vector2(x: inputManager.AxisRawHorizontal, y: inputManager.AxisRawVertical).normalized;
        if (direction.magnitude <= 0f) stateMachine.TransitionTo(nextState: idle);
    }
}