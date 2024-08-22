using UnityEngine;

public sealed class WeaponAim : MonoBehaviour
{
    private AbstractScenePlayable playableScene;

    private void Awake() => playableScene = GetComponentInParent<AbstractScenePlayable>();

    private void Update()
    {
        var mousePointerWorldPosition = playableScene.MainCamera.MousePointerWorldPosition;
        transform.position = new Vector3(x: mousePointerWorldPosition.x, y: mousePointerWorldPosition.y, z: 0f);
    }
}