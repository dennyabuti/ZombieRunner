using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ReloadGame()
    {
      int currentScene = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(currentScene);
      Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
