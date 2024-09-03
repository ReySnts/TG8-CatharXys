using UnityEngine;

public sealed class Switchable : MonoBehaviour, ISwitchable
{
    [field: SerializeField] public bool IsActive { get; set; }

    private IGameObject iGameObject;

    private void Awake() => iGameObject = GetComponentInChildren<IGameObject>();

    private void Update() => iGameObject.GameObject.SetActive(value: IsActive);
}