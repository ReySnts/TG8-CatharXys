using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEMoveable
{
    Rigidbody2D rb { get; set; }

    bool IsFacingRight { get; set; }

    void MoveEnemy(Vector2 velocity);
    void CheckDir(Vector2 velocity);
}
