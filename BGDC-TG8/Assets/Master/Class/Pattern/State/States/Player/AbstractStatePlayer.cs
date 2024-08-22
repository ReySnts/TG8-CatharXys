public abstract class AbstractStatePlayer : AbstractState
{
    protected AbstractContext<AbstractAnimationPlayer> contextAnimationPlayer;

    protected AbstractScenePlayable playableScene;

    protected override void Awake()
    {
        base.Awake();
        contextAnimationPlayer = GetComponentInParent<AbstractContext<AbstractAnimationPlayer>>();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }
}