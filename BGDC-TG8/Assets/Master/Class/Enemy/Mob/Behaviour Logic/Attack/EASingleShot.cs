using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attack Single Shot", menuName = "Enemy Logic/Attack Logic/SingleShot")]

public class EASingleShot : EnemyAttackSO
{
    [SerializeField] private Rigidbody2D BulletPrefab; 
    [SerializeField] private float bulletSpeed = 10f; 
    [SerializeField] private float shootCD = 2f;  
    [SerializeField] private float timeTillExit = 3f; 
    [SerializeField] private float distanceCountExit = 3f;

    private float timer; 
    private float exitTimer;

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

        enemy.MoveEnemy(Vector2.zero); 

        if(timer > shootCD)
        {
            timer = 0f; 

            Vector2 direction = (playerTransform.position - enemy.transform.position).normalized; 

            Rigidbody2D bullet = GameObject.Instantiate(BulletPrefab, enemy.transform.position, Quaternion.identity);

            bullet.velocity = direction * bulletSpeed; 
        }

        if(Vector2.Distance(playerTransform.position, enemy.transform.position) > distanceCountExit)
        {
            exitTimer += Time.deltaTime; 

            if(exitTimer > timeTillExit)
            {
                enemy.StateMachine.ChangeState(enemy.ChaseState);
            }
        }

        timer += Time.deltaTime;
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
