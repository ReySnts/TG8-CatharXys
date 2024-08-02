using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState
{
    protected Enemy enemy; 
    protected EnemyStateMachine esm; 

    public EnemyState(Enemy enemy, EnemyStateMachine esm)
    {
        this.enemy = enemy; 
        this.esm = esm;
    }

    public virtual void EnterState() {}

    public virtual void ExitState() {}

    public virtual void FrameUpdate() {}

    public virtual void PhysicsUpdate() {}

    public virtual void AnimationTriggerEvent() {}
}
