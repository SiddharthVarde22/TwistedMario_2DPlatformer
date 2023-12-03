using UnityEngine.UI;
using UnityEngine;

public class LevelLoader_Button : MonoBehaviour
{
    [SerializeField]
    Button levelLoaderButton;
    [SerializeField]
    int levelToLoad;

    void Start()
    {
        levelLoaderButton.onClick.AddListener(OnLevelLoadButtonPressed);
    }

    public void OnLevelLoadButtonPressed()
    {
        ServiceLocator.Instance.sceneLoader.LoadLevel(levelToLoad);
    }
}
