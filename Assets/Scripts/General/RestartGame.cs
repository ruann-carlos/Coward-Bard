using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public static Action CloseDeathUi;
    public void RestartScene()
    {
        Time.timeScale = 1;
        CloseDeathUi();
        SceneManager.LoadScene("MainScene");

    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        CloseDeathUi();
        SceneManager.LoadScene("MainMenu");
    }
}
