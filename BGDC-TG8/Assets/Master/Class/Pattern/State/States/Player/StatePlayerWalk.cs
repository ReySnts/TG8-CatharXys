using UnityEngine;

public sealed class StatePlayerWalk : AbstractState
{
    [SerializeField] private AbstractState idle;

    private AbstractScenePlayable playableScene;

    private AbstractStrategy<AbstractAnimationPlayer> animationStrategy;

    protected override void Awake()
    {
        base.Awake();
        animationStrategy = GetComponentInParent<AbstractStrategy<AbstractAnimationPlayer>>();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }

    public override void Enter() => animationStrategy.SetStrategy(strategy: animationStrategy.GetComponentInChildren<AnimationPlayerWalk>());

    public override void DoUpdate()
    {
        var inputManager = playableScene.InputManager;
        var direction = new Vector2(x: inputManager.AxisRawHorizontal, y: inputManager.AxisRawVertical).normalized;
        if (direction.magnitude <= 0f) stateMachine.TransitionTo(nextState: idle);
    }
}