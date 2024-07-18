using UnityEngine;

public abstract class CanvasMenu : MonoBehaviour, ICanvasMenu
{
    public GameObject GameObject => gameObject;
}