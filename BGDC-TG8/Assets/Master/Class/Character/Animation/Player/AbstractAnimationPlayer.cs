using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractList<string>))]

public abstract class AbstractAnimationPlayer : AbstractAnimation
{
    private AbstractList<string> listStateDirection;

    protected override void Awake()
    {
        base.Awake();
        listStateDirection = GetComponent<AbstractList<string>>();
    }

    public void Play(int directionIndex) => animator.Play(stateName: listStateDirection.List[index: directionIndex]);
}