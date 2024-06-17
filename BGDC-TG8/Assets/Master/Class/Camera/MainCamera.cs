using UnityEngine;

public class MainCamera : MonoBehaviour, ICamera
{
    public Camera Camera { get; private set; }

    private void Awake() => Camera = GetComponent<Camera>();
}