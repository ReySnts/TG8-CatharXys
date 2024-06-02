public interface IPlayer
{
    public abstract IAnimationDirection AnimationDirection { get; }

    public abstract IInput Input { get; }

    public abstract IMovement Movement { get; }

    public abstract IStateMachine<State> StateMachine { get; }
}