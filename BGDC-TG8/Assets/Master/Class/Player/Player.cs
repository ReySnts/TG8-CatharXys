using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    public IAnimationDirection IAnimationDirection { get; private set; }

    public IInput IInput { get; private set; }

    public IMovement IMovement { get; private set; }

    public IStateMachine<IState> IStateMachine { get; private set; }

    public IWeapon IWeapon { get; private set; }

    private void Awake()
    {
        IAnimationDirection = GetComponentInChildren<IAnimationDirection>();
        IInput = GetComponentInChildren<IInput>();
        IMovement = GetComponentInChildren<IMovement>();
        IStateMachine = GetComponentInChildren<IStateMachine<IState>>();
        IWeapon = GetComponentInChildren<IWeapon>();
    }
}