using UnityEngine;

public abstract class AbstractState : MonoBehaviour
{
    protected AbstractCharacter character;

    protected AbstractStateMachine<AbstractState, AbstractState> stateMachine;

    public abstract void Enter();

    public abstract void DoUpdate();

    protected virtual void Awake()
    {
        character = GetComponentInParent<AbstractCharacter>();
        stateMachine = GetComponentInParent<AbstractStateMachine<AbstractState, AbstractState>>();
    }
}