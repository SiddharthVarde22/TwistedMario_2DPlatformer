using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_InputReader : MonoBehaviour
{
    [SerializeField]
    PlayerView playerView;
    PlayerController playerController;

    InputService currentInputService;

    private void Start()
    {
        currentInputService = ServiceLocator.Instance.currentInputService;
    }

    private void Update()
    {
        GetPlayerControllerIfNull();

        
    }

    public void GetPlayerControllerIfNull()
    {
        if (playerController == null)
        {
            playerController = playerView.GetPlayerController();
        }
    }
}
