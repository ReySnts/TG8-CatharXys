using UnityEngine;

public abstract class AbstractStateMachine<TCurrentState, TNextState> : MonoBehaviour
{
    [SerializeField] protected TCurrentState currentState;

    public abstract void TransitionTo(TNextState nextState);
}