using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject Menu, Levels, Credits;

    private void Awake()
    {
        Menu.SetActive(true);
        Levels.SetActive(false);
        Credits.SetActive(false);
    }

    public void ShowLevels()
    {
        Menu.SetActive(false);
        Levels.SetActive(true);
    }

    public void ShowCredits()
    {
        Menu.SetActive(false);
        Credits.SetActive(true);
    }
    public void BackToMainMenu()
    {
        Menu.SetActive(true);
        Levels.SetActive(false);
        Credits.SetActive(false);
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
