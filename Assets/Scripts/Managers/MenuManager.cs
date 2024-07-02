using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject Menu, Levels, Credits;

    public static MenuManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            //DontDestroyOnLoad(this);
        }

        Menu.SetActive(true);
        Levels.SetActive(false);
        Credits.SetActive(false);
    }

    public void SelectLevels()
    {
        Menu.SetActive(false);
        Levels.SetActive(true);
    }

    public void Back()
    {
        Menu.SetActive(true);
        Levels.SetActive(false);
        Credits.SetActive(false);
    }

    public void ShowCredits()
    {
        Menu.SetActive(false);
        Credits.SetActive(true);
    }

    public void LoadScene(string nombreScene)
    {
        SceneManager.LoadScene(nombreScene,LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
