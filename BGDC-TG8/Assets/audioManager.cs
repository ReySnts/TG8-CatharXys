using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource music;

    private void Start()
    {
        music.Play();
    }

    public void StopMusic()
    {
        music.Stop();
    }
}
