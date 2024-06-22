using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioClip sfxCast;
    [SerializeField] CastSpell spell;
    [SerializeField] float cooldown;

    private float timer = 5;

    public static GameManager Instance { get; private set; }

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

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > cooldown)
        {
            spell.LoadingAnimation(false);
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
}
