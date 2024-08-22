using UnityEngine;

public sealed class WeaponLongPlayer : AbstractWeaponLong
{
    private AbstractScenePlayable playableScene;

    private float cooldown;

    protected override void Awake()
    {
        base.Awake();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }

    private void Update() => Trigger();

    protected override void Trigger()
    {
        if (playableScene.InputManager.MouseButtonDownLeft && Time.time > cooldown)
        {
            cooldown = Time.time + fireRate;
            bulletFactory.GetProduct(product: playableScene.MainCamera.MousePointerWorldPosition, parent: bulletFactory.transform);
        }
    }
}