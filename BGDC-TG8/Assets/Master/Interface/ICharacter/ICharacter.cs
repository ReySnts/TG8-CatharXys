public interface ICharacter
{
    public abstract IAnimationDirection IAnimationDirection { get; }

    public abstract IMovement IMovement { get; }

    public abstract IStateMachine<IState> IStateMachine { get; }
}