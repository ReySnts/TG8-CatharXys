public class NormalStateMachine : StateMachineScript<State, State>
{
    public override void TransitionTo(State nextState) => currentState = nextState;

    private void Update() => currentState.DoUpdate();
}