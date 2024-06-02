using UnityEngine;

public class StateMachine : MonoBehaviour, IStateMachine<State>
{
    [SerializeField] private State currentState;

    public void TransitionTo(State nextState) => currentState = nextState;

    private void Update() => currentState.DoUpdate();
}