using UnityEngine;

public class StateRun : State
{
    [SerializeField] private State idleState;

    public override void DoUpdate()
    {
        var character = iCharacter;
        var playerMovementDirection = character.IMovement.Direction;
        if (playerMovementDirection.magnitude <= 0f) character.IStateMachine.TransitionTo(nextState: idleState);
        else
        {
            var directionAnimation = character.IAnimationDirection;
            directionAnimation.LastDirectionIndex = directionAnimation.IndexOf(parameter: playerMovementDirection);
            directionAnimation.Animator.Play(stateName: list.List[index: directionAnimation.LastDirectionIndex]);
        }
    }
}