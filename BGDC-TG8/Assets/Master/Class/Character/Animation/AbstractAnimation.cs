using UnityEngine;

[RequireComponent(requiredComponent: typeof(Animator))]

public abstract class AbstractAnimation : MonoBehaviour
{
    protected Animator animator;

    public Animator Animator => animator;

    protected virtual void Awake() => animator = GetComponent<Animator>();
}