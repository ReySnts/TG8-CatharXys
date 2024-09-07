using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //private int currentSceneIndex;

    //private void Awake()
    //{
    //    currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    //}

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
