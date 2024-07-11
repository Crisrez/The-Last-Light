using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AudioManager : MonoBehaviour
{
    private FMOD.Studio.EventInstance fMOD;

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
        }
    }

    private void Start()
    {
    }

    /*public void PlaySound(AudioClip audioClip)
    {
        sFXSource.PlayOneShot(audioClip);
    }

    public void PlayMusic(AudioClip audioclip)
    {
        musicSource.PlayOneShot(audioclip);
    }*/

    public void Silenciar()
    {
        /*if (GameManager.Instance.isGamePaused())
        {
            slimeSource.Pause();
        }
        else
        {
            slimeSource.UnPause();
        }*/
    }

    public void PlaySteps()
    {

        fMOD = FMODUnity.RuntimeManager.CreateInstance("event:/StepsLoop");
        fMOD.start();
    }

    public void PauseSteps()
    {
        fMOD.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        fMOD.release();
    }

    public void PlayMagic()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Power");
    }
}
