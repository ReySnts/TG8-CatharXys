using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine
{
    public EnemyState CurrEnemyState {get; set;}

    public void Initialize(EnemyState startingState)
    {
        CurrEnemyState = startingState;
        CurrEnemyState.EnterState();
    }

    public void ChangeState(EnemyState newState)
    {
        CurrEnemyState.ExitState();
        CurrEnemyState = newState;
        CurrEnemyState.EnterState();
    }
}
