using UnityEngine;

public class PlayerWeapon : MonoBehaviour, IWeapon
{
    [SerializeField] private float fireRate = 1f;

    public GameObject GameObject => gameObject;

    private IFactory<Vector2> iFactory;

    private IScene iScene;

    private float cooldown;

    private void Awake()
    {
        iFactory = GetComponentInChildren<IFactory<Vector2>>();
        iScene = GetComponentInParent<IScene>();
    }

    private void Update()
    {
        if (iScene.IPlayer.IInput.LeftMouseButtonDown && Time.time > cooldown)
        {
            cooldown = Time.time + fireRate;
            iFactory.GetProduct(parameter: iScene.ICamera.MousePointerClickPosition);
        }
    }
}