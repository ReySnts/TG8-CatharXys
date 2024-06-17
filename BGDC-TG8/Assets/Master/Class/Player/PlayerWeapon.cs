using UnityEngine;

public class PlayerWeapon : MonoBehaviour, IWeapon
{
    private IFactory<Vector2> iFactory;

    private IScene iScene;

    private void Awake()
    {
        iFactory = GetComponent<IFactory<Vector2>>();
        iScene = GetComponentInParent<IScene>();
    }

    private void Update()
    {
        if (iScene.IPlayer.IInput.LeftMouseButtonDown)
        {
            var mousePointerClickPosition = iScene.ICamera.Camera.ScreenToWorldPoint(Input.mousePosition);
            iFactory.GetProduct(parameter: mousePointerClickPosition);
        }
    }
}