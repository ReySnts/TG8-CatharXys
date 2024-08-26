using UnityEngine;

public sealed class WeaponLongPlayer : AbstractWeaponLong
{
    private AbstractScenePlayable playableScene;

    private AudioSource audioSource;

    private float cooldown;

    protected override void Awake()
    {
        base.Awake();
        audioSource = GetComponentInChildren<AudioSource>();
        playableScene = GetComponentInParent<AbstractScenePlayable>();
    }

    private void Update() => Trigger();

    protected override void Trigger()
    {
        if (playableScene.InputManager.MouseButtonDownLeft && Time.time > cooldown)
        {
            audioSource.Play();
            bulletFactory.GetProduct(product: playableScene.MainCamera.MousePointerWorldPosition, parent: bulletFactory.transform);
            cooldown = Time.time + fireRate;
        }
    }
}