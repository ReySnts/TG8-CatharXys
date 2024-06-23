using UnityEngine;

public class MainCamera : MonoBehaviour, ICamera
{
    public Vector3 MousePointerClickPosition => _camera.ScreenToWorldPoint(position: iScene.IPlayer.IInput.MousePosition);

    private Camera _camera;

    private IScene iScene;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
        iScene = GetComponentInParent<IScene>();
    }
}