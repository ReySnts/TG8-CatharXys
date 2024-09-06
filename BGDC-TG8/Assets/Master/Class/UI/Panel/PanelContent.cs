using UnityEngine;

public sealed class PanelContent : MonoBehaviour, IGameObject
{
    public GameObject GameObject => gameObject;
}