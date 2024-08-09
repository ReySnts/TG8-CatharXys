using UnityEngine;

public abstract class AbstractState : MonoBehaviour
{
    protected AbstractStateMachine<AbstractState, AbstractState> stateMachine;

    public abstract void Enter();

    public abstract void DoUpdate();

    protected virtual void Awake() => stateMachine = GetComponentInParent<AbstractStateMachine<AbstractState, AbstractState>>();
}