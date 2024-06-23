using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioClip sfxCast;
    [SerializeField] CastSpell spell;
    [SerializeField] float cooldown;

    [SerializeField] GameObject M_Pause;

    private bool isPause = false;
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

        if (Time.timeScale > 0)
        {
            isPause = false;
        }
        else
        {
            isPause = true;
        }

        if (timer > cooldown)
        {
            spell.LoadingAnimation(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActivarMenu(M_Pause);
        }
    }


    public void CastLight()
    {
        if (timer > cooldown)
        {
            timer = 0;
            AudioManager.Instance.PlaySound(sfxCast);
            spell.Echolocation();
            spell.LoadingAnimation(true);
        }
    }

    public void ChangeTime(int valorTiempo)
    {
        Time.timeScale = valorTiempo;
    }

    public void ActivarPause()
    {
        if (!isPause)
        {
           ChangeTime(0);
        }
        else
        {
            ChangeTime(1);
        }
        
    }

    public void ActivarMenu(GameObject menu)
    {
        if (!isPause)
        {
            menu.SetActive(true);
            ActivarPause();
            AudioManager.Instance.Silenciar();
        }
        else
        {
            menu.SetActive(false);
            ActivarPause();
            AudioManager.Instance.Silenciar();
        }

    }

    public bool isGamePaused()
    {
        return isPause;
    }

}
