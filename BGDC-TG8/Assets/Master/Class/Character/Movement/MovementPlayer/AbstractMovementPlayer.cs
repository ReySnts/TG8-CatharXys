public abstract class AbstractMovementPlayer : AbstractMovement
{
    protected AbstractScenePlayable playableScene;

    protected override void Awake()
    {
        base.Awake();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }
}