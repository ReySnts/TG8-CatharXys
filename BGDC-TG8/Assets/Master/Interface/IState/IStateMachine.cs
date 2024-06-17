public interface IStateMachine<TNextState>
{
    public abstract void TransitionTo(TNextState nextState);
}