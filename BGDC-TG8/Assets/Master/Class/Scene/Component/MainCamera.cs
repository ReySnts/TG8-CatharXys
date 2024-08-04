using UnityEngine;

public sealed class MainCamera : MonoBehaviour
{
    private Camera _camera;

    private AbstractScenePlayable playableScene;

    //public Vector3 MousePointerClickPosition => _camera.ScreenToWorldPoint(position: playableScene.Player.IInput.MousePosition);

    private void Awake()
    {
        _camera = GetComponent<Camera>();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }
}