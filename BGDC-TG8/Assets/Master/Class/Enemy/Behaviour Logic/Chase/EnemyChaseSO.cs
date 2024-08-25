using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseSO : ScriptableObject
{
    protected Enemy enemy; 
    protected Transform transform; 
    protected GameObject gameObject; 
    protected Transform playerTransform; 

    public virtual void Initialize(GameObject gameObject, Enemy enemy)
    {
        this.gameObject = gameObject; 
        transform = gameObject.transform; 
        this.enemy = enemy; 
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
        
    public virtual void DoEnterLogic() {}

    public virtual void DoExitLogic() {ResetValues();}

    public virtual void DoFrameUpdateLogic()
    {
        if(enemy.IsAttackFeasible)
        {
            enemy.StateMachine.ChangeState(enemy.AttackState);
        }
    }

    public virtual void DoPhysicsLogic() {}

    public virtual void DoAnimationLogic(Enemy.AnimationTriggerType triggerType) {}
        
    public virtual void ResetValues() {}
}
