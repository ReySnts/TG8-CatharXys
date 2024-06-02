using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    public IAnimationDirection AnimationDirection { get; private set; }

    public IInput Input { get; private set; }

    public IMovement Movement { get; private set; }

    public IStateMachine<State> StateMachine { get; private set; }

    private void Awake()
    {
        AnimationDirection = GetComponentInChildren<IAnimationDirection>();
        Input = GetComponentInChildren<IInput>();
        Movement = GetComponentInChildren<IMovement>();
        StateMachine = GetComponentInChildren<IStateMachine<State>>();
    }
}