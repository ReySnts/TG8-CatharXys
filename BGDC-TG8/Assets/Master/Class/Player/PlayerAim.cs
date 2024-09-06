using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    private IScene iScene;

    private void Awake() => iScene = GetComponentInParent<IScene>();

    private void Update()
    {
        var mousePos = iScene.ICamera.MousePointerClickPosition;
        var rotate = mousePos - transform.position;
        var rotZ = Mathf.Atan2(y: rotate.y, x: rotate.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}