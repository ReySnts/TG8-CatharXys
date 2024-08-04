using UnityEngine;

public sealed class StatePlayerIdle : AbstractState
{
    [SerializeField] private AbstractState walk;

    private AbstractScenePlayable playableScene;

    private AbstractStrategy<AbstractAnimationPlayer> animationStrategy;

    protected override void Awake()
    {
        base.Awake();
        animationStrategy = GetComponentInParent<AbstractStrategy<AbstractAnimationPlayer>>();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }

    public override void Enter() => animationStrategy.SetStrategy(strategy: animationStrategy.GetComponentInChildren<AnimationPlayerIdle>());

    public override void DoUpdate()
    {
        var inputManager = playableScene.InputManager;
        var direction = new Vector2(x: inputManager.AxisRawHorizontal, y: inputManager.AxisRawVertical).normalized;
        if (direction.magnitude > 0f) stateMachine.TransitionTo(nextState: walk);
    }
}