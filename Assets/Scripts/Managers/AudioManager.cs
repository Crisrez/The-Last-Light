using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sFXSource, musicSource;

    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void PlaySound(AudioClip audioClip)
    {
        sFXSource.PlayOneShot(audioClip);
    }

    public void PlayMusic(AudioClip audioclip)
    {
        musicSource.PlayOneShot(audioclip);
    }

}
