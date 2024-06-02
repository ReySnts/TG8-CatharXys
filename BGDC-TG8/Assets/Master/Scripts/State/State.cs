using UnityEngine;

public abstract class State : MonoBehaviour, IState
{
    protected IList<string> list;

    protected IPlayer player;

    public abstract void DoUpdate();

    private void Awake()
    {
        list = GetComponent<IList<string>>();
        player = GetComponentInParent<IPlayer>();
    }
}