using UnityEngine;

public class StateIdle : State
{
    [SerializeField] private State runState;

    public override void DoUpdate()
    {
        var player = this.player;
        if (player.Movement.Direction.magnitude > 0f) player.StateMachine.TransitionTo(nextState: runState);
        else
        {
            var directionAnimation = player.AnimationDirection;
            directionAnimation.Animator.Play(stateName: list.List[index: directionAnimation.LastDirectionIndex]);
        }
    }
}