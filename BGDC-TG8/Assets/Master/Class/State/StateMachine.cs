using UnityEngine;

public class StateMachine : MonoBehaviour, IStateMachine<IState>
{
    [SerializeField] private State currentState;

    public void TransitionTo(IState nextState) => currentState = nextState as State;

    private void Update() => currentState.DoUpdate();
}