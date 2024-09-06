using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected ListScript<string> list;

    protected ICharacter iCharacter;

    public abstract void DoUpdate();

    private void Awake()
    {
        list = GetComponent<ListScript<string>>();
        iCharacter = GetComponentInParent<ICharacter>();
    }
}