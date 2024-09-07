using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyChecker : MonoBehaviour
{
    private int currentSceneIndex;
    private int nextScene;

    private void Awake()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        nextScene = currentSceneIndex + 1;
        Debug.Log(currentSceneIndex);
        Debug.Log(nextScene);
    }
    void Update()
    {
        if (transform.childCount< 1)
        {
            SceneManager.LoadScene(currentSceneIndex+1);
        }
    }
}
