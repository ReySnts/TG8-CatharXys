using UnityEngine;

public abstract class StateMachineScript<TCurrentState, TNextState> : MonoBehaviour, IStateMachine<TNextState>
{
    [SerializeField] protected TCurrentState currentState;

    public abstract void TransitionTo(TNextState nextState);
}