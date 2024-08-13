using UnityEngine;

[RequireComponent(requiredComponent: typeof(Camera))]

public sealed class MainCamera : MonoBehaviour
{
    [SerializeField] private float offsetX;

    [SerializeField] private float offsetY;

    private Camera _camera;

    private AbstractScenePlayable playableScene;

    private Vector2 mousePointerWorldPosition;

    public Vector2 MousePointerWorldPosition => mousePointerWorldPosition;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }

    private void Update()
    {
        mousePointerWorldPosition = _camera.ScreenToWorldPoint(position: playableScene.InputManager.MousePosition);
        var clampedX = Mathf.Clamp(value: mousePointerWorldPosition.x, min: transform.position.x - offsetX, max: transform.position.x + offsetX);
        var clampedY = Mathf.Clamp(value: mousePointerWorldPosition.y, min: transform.position.y - offsetY, max: transform.position.y + offsetY);
        mousePointerWorldPosition = new Vector2(x: clampedX, y: clampedY);
    }
}