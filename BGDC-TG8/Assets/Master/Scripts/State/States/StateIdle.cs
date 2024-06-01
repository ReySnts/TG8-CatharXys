using UnityEngine;

public class StateIdle : State
{
    [SerializeField] private State runState;

    public override void Enter()
    {
        var moveAnimation = movement.Animation;
        moveAnimation.Animator.Play(stateName: list.List[index: moveAnimation.LastDirectionIndex]);
    }

    public override void DoUpdate()
    {
        if (movement.Direction.magnitude > 0f) stateMachine.TransitionTo(nextState: runState);
    }
}