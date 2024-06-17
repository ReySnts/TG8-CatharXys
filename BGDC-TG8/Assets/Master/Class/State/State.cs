using UnityEngine;

public abstract class State : MonoBehaviour, IState
{
    protected IList<string> list;

    protected ICharacter iCharacter;

    public abstract void DoUpdate();

    private void Awake()
    {
        list = GetComponent<IList<string>>();
        iCharacter = GetComponentInParent<ICharacter>();
    }
}