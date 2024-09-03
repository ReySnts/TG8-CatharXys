using UnityEngine;

public sealed class RotatorMuzzle : AbstractRotator
{
    private AbstractScenePlayable playableScene;

    private void Awake() => playableScene = GetComponentInParent<AbstractScenePlayable>();

    private void Update()
    {
        var mousePointerWorldPosition = playableScene.MainCamera.MousePointerWorldPosition;
        var direction = (mousePointerWorldPosition - (Vector2)transform.position).normalized;
        var angle = Mathf.Atan2(y: direction.y, x: direction.x) * Mathf.Rad2Deg - 90f;
        var euler = new Vector3(x: 0f, y: 0f, z: angle);
        transform.rotation = Quaternion.Euler(euler);
    }
}