using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable, IEMoveable, ITriggerable
{
    [field: SerializeField] public float MaxHealth{get; set;} = 100f;
    public float CurrentHealth{get; set;}

    public Rigidbody2D rb {get; set;}

    public bool IsFacingRight {get; set;} = true;

    public bool IsAggroed {get; set;}

    public bool IsAttackFeasible {get; set;}

    #region State Machine Variables
    public EnemyStateMachine StateMachine {get; set;}
    public EnemyIdleState IdleState {get; set;}
    public EnemyChaseState ChaseState {get; set;}
    #endregion

    #region Idle Variables
    public float RandomMoveRange = 5f; 
    public float RandomMoveSPeed = 1f;
    #endregion 

    private void Awake()
    {
        StateMachine = new EnemyStateMachine();

        IdleState = new EnemyIdleState(this, StateMachine);
        ChaseState = new EnemyChaseState(this, StateMachine);
    }

    public void Start()
    {
        CurrentHealth = MaxHealth;

        rb = GetComponent<Rigidbody2D>();

        StateMachine.Initialize(IdleState);
    }

    private void Update()
    {
        StateMachine.CurrEnemyState.FrameUpdate();
    }

    private void FixedUpdate()
    {
        StateMachine.CurrEnemyState.PhysicsUpdate();
    }

    #region Health/Die Functions
    public void Damage(float damageAmount)
    {
        CurrentHealth -= damageAmount;

        if(CurrentHealth <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {

    }
    #endregion

    #region Movement Functions
    public void MoveEnemy(Vector2 velocity)
    {
        rb.velocity = velocity; 
        CheckDir(velocity);
    }

    public void CheckDir(Vector2 velocity)
    {
        if(IsFacingRight && velocity.x < 0f)
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            IsFacingRight = !IsFacingRight;
        }

        else if(!IsFacingRight && velocity.x > 0f)
        {
            Vector3 rotator = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rotator);
            IsFacingRight = !IsFacingRight;
        }
    }
    #endregion

    #region Distance Checks
    public void SetAggroStatus(bool isAggroed)
    {
        IsAggroed = isAggroed;
    }

    public void SetAttackStatus(bool isAttackFeasible)
    {
        IsAttackFeasible = isAttackFeasible;
    }
    #endregion

    #region Animation Triggers

    private void AnimationTriggerEvent (AnimationTriggerType triggerType)
    {
        StateMachine.CurrEnemyState.AnimationTriggerEvent(triggerType);
    }

    public enum AnimationTriggerType
    {
        EnemyDamaged,
        PlayFootstepSound
    }
    #endregion
}
