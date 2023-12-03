using UnityEngine.UI;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [SerializeField]
    Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(OnQuitButtonPressed);
    }

    public void OnQuitButtonPressed()
    {
        ServiceLocator.Instance.sceneLoader.QuitTheGame();
    }
}
