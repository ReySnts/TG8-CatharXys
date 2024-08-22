public sealed class StateMachine : AbstractStateMachine<AbstractState, AbstractState>
{
    private void Awake() => TransitionTo(nextState: currentState);

    public override void TransitionTo(AbstractState nextState)
    {
        currentState = nextState;
        nextState.Enter();
    }

    private void Update() => currentState.DoUpdate();
}