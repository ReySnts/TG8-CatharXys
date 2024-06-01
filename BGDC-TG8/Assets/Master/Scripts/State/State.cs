using UnityEngine;

public abstract class State : MonoBehaviour, IState
{
    protected IList<string> list;

    protected IStateMachine<State> stateMachine;

    protected IMovement movement;

    public abstract void Enter();

    public abstract void DoUpdate();

    private void Awake()
    {
        list = GetComponent<IList<string>>();
        stateMachine = GetComponentInParent<IStateMachine<State>>();
        movement = GetComponentInParent<IMovement>();
    }
}