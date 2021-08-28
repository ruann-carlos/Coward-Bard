using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private string sceneToLoad;

    public void LoadScene()
    {
        StartCoroutine(LoadScenes(sceneToLoad));
    }

    public static IEnumerator LoadScenes(string scene)
    {
        AsyncOperation asyncLoadScene = SceneManager.LoadSceneAsync(scene);

        while (!asyncLoadScene.isDone)
        {
            yield return null;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
