using UnityEngine;

[RequireComponent(requiredComponent: typeof(Rigidbody2D))]

public abstract class AbstractCharacter : MonoBehaviour
{
    //public AbstractMovement Movement { get; private set; }

    public Rigidbody2D Rigidbody2D { get; set; }

    protected virtual void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        //Movement = GetComponentInChildren<AbstractMovement>();
    }
}