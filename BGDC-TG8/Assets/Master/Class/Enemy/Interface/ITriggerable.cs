using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerable
{
    bool IsAggroed {get; set;}
    bool IsAttackFeasible {get; set;}

    void SetAggroStatus(bool isAggroed);
    void SetAttackStatus(bool isAttackFeasible);
}
