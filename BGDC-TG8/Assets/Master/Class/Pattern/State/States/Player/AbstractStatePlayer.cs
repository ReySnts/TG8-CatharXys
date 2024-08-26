public abstract class AbstractStatePlayer : AbstractState
{
    protected AbstractContext<AbstractAnimationPlayer> contextAnimationPlayer;

    protected AbstractContext<AbstractAudioClip> contextSoundPlayer;

    protected AbstractScenePlayable playableScene;

    protected override void Awake()
    {
        base.Awake();
        contextAnimationPlayer = GetComponentInParent<AbstractContext<AbstractAnimationPlayer>>();
        contextSoundPlayer = GetComponentInParent<AbstractContext<AbstractAudioClip>>();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }
}