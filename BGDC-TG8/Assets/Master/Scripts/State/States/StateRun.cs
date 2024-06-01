using UnityEngine;

public class StateRun : State
{
    [SerializeField] private State idleState;

    public override void Enter()
    {
        var moveAnimation = movement.Animation;
        moveAnimation.LastDirectionIndex = moveAnimation.IndexOf(parameter: movement.Direction);
        moveAnimation.Animator.Play(stateName: list.List[index: moveAnimation.LastDirectionIndex]);
    }

    public override void DoUpdate()
    {
        if (movement.Direction.magnitude <= 0f) stateMachine.TransitionTo(nextState: idleState);
    }
}