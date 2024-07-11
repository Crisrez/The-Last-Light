using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //[SerializeField] AudioClip sfxCast;
    [SerializeField] CastSpell spell;
    [SerializeField] float cooldown;

    [SerializeField] GameObject M_Pause;

    private bool isPaused = false;
    private float timer = 5;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        ChangeTime(1);

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        /*if (Time.timeScale > 0)
        {
            isPaused = false;
        }
        else
        {
            isPaused = true;
        }*/

        if (timer > cooldown)
        {
            spell.LoadingAnimation(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && (!isPaused || M_Pause.activeInHierarchy))
        {
            ActivarMenu(M_Pause);
        }
    }

    public void ActivarMenu(GameObject menu)
    {
        if (!isPaused)
        {
            menu.SetActive(true);
            ActivarPause();
            //AudioManager.Instance.Silenciar();
        }
        else
        {
            menu.SetActive(false);
            ActivarPause();
            //AudioManager.Instance.Silenciar();
        }

    }

    public void ActivarPause()
    {
        if (!isPaused)
        {
           ChangeTime(0);
            isPaused = true;
        }
        else
        {
           ChangeTime(1);
            isPaused = false;
        }
        
    }

    public void ChangeTime(int valorTiempo)
    {
        Time.timeScale = valorTiempo;
    }


    public void CastLight()
    {
        if (timer > cooldown)
        {
            timer = 0;
            AudioManager.Instance.PlayMagic();
            spell.Echolocation();
            spell.LoadingAnimation(true);
        }
    }


    public bool isGamePaused()
    {
        return isPaused;
    }

    public float GetTimer()
    {
        return timer;
    }

}
