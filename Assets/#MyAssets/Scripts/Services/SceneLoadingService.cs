using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingService
{
    public void LoadNextScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;

        if((index + 1) >= SceneManager.sceneCountInBuildSettings)
        {
            index = 0;
        }

        SceneManager.LoadScene(index);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
