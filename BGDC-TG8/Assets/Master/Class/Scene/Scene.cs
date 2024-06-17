using UnityEngine;

public class Scene : MonoBehaviour, IScene
{
    public ICamera ICamera { get; private set; }

    public IPlayer IPlayer { get; private set; }

    private void Awake()
    {
        ICamera = GetComponentInChildren<ICamera>();
        IPlayer = GetComponentInChildren<IPlayer>();
    }
}