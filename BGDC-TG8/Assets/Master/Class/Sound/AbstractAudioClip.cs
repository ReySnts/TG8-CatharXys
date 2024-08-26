using UnityEngine;

public abstract class AbstractAudioClip : MonoBehaviour
{
    [field: SerializeField] public AudioClip AudioClip { get; private set; }

    [field: SerializeField] public bool Loop { get; private set; }
}