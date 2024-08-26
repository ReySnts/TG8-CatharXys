using UnityEngine;

public sealed class ContextSoundPlayer : AbstractContext<AbstractAudioClip>
{
    private AudioSource audioSource;

    private void Awake() => audioSource = GetComponentInChildren<AudioSource>();

    public override void SetStrategy(AbstractAudioClip strategy)
    {
        audioSource.Stop();
        base.SetStrategy(strategy);
        audioSource.clip = strategy?.AudioClip;
        audioSource.loop = strategy ? strategy.Loop : false;
        audioSource.Play();
    }
}