using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingService
{
    int gameWinSceneBuildIndex, gameLoseSceneBuildIndex, mainMenuSceneBuildIndex;
    public SceneLoadingService(int gameWinBuildIndex, int gameLoseBuildIndex, int mainMunuBuildIndex)
    {
        this.gameWinSceneBuildIndex = gameWinBuildIndex;
        this.gameLoseSceneBuildIndex = gameLoseBuildIndex;
        this.mainMenuSceneBuildIndex = mainMunuBuildIndex;
    }

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

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadPlayerWinLevel()
    {
        SceneManager.LoadScene(gameWinSceneBuildIndex);
    }

    public void LoadGameLoseLevel()
    {
        SceneManager.LoadScene(gameLoseSceneBuildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneBuildIndex);
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }
}
