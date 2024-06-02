using UnityEngine;

public class StateRun : State
{
    [SerializeField] private State idleState;

    public override void DoUpdate()
    {
        var player = this.player;
        var playerMovementDirection = player.Movement.Direction;
        if (playerMovementDirection.magnitude <= 0f) player.StateMachine.TransitionTo(nextState: idleState);
        else
        {
            var directionAnimation = player.AnimationDirection;
            directionAnimation.LastDirectionIndex = directionAnimation.IndexOf(parameter: playerMovementDirection);
            directionAnimation.Animator.Play(stateName: list.List[index: directionAnimation.LastDirectionIndex]);
        }
    }
}