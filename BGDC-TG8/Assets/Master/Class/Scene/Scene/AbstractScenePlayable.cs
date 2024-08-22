using UnityEngine;

[RequireComponent(requiredComponent: typeof(InputManager))]

public abstract class AbstractScenePlayable : MonoBehaviour
{
    public MainCamera MainCamera { get; private set; }

    public InputManager InputManager { get; private set; }

    public AbstractCharacter Player { get; private set; }

    private void Awake()
    {
        InputManager = GetComponent<InputManager>();
        MainCamera = GetComponentInChildren<MainCamera>();
        Player = GetComponentInChildren<CharacterPlayer>();
    }
}