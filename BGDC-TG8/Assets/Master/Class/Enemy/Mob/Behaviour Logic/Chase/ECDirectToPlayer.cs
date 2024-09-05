using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Chase Direct To Player", menuName = "Enemy Logic/Chase Logic/DirectToPlayer")]

public class ECDirectToPlayer : EnemyChaseSO
{
    [SerializeField] private float MoveSpeed = 3f;

    public override void DoAnimationLogic(Enemy.AnimationTriggerType triggerType)
    {
        base.DoAnimationLogic(triggerType);
    }

    public override void DoEnterLogic()
    {
        base.DoEnterLogic();
    }

    public override void DoExitLogic()
    {
        base.DoExitLogic();
    }

    public override void DoFrameUpdateLogic()
    {
        base.DoFrameUpdateLogic();

        Vector2 moveDirection = (playerTransform.position - enemy.transform.position).normalized; 

        enemy.MoveEnemy(moveDirection * MoveSpeed);
    }

    public override void DoPhysicsLogic()
    {
        base.DoPhysicsLogic();
    }

    public override void Initialize(GameObject gameObject, Enemy enemy)
    {
        base.Initialize(gameObject, enemy);
    }

    public override void ResetValues()
    {
        base.ResetValues();
    }
}
