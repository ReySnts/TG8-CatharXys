using UnityEngine;

public sealed class PlayerAim : MonoBehaviour
{
    private AbstractScenePlayable playableScene;

    private void Awake() => playableScene = GetComponentInParent<AbstractScenePlayable>();

    private void Update()
    {
        //var mousePos = playableScene.MainCamera.MousePointerClickPosition;
        //var rotate = mousePos - transform.position;
        //var rotZ = Mathf.Atan2(y: rotate.y, x: rotate.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}