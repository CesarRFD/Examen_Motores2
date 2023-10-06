using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void InitialMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}