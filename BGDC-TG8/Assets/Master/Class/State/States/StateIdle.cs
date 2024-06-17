using UnityEngine;

public class StateIdle : State
{
    [SerializeField] private State runState;

    public override void DoUpdate()
    {
        var character = iCharacter;
        if (character.IMovement.Direction.magnitude > 0f) character.IStateMachine.TransitionTo(nextState: runState);
        else
        {
            var directionAnimation = character.IAnimationDirection;
            directionAnimation.Animator.Play(stateName: list.List[index: directionAnimation.LastDirectionIndex]);
        }
    }
}