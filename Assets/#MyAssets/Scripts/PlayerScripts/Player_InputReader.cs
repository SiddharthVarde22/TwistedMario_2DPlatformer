using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_InputReader : MonoBehaviour
{
    [SerializeField]
    PlayerView playerView;
    PlayerController playerController;

    InputService currentInputService;

    private void Update()
    {
        GetPlayerControllerIfNull();
        GetPlayerInputServiceIfNull();
        currentInputService.GetHorizontalInput();
        currentInputService.GetJumpInput();
        currentInputService.GetFireInput();

        playerController.MovePlayerHorizontal(currentInputService.HorizontalInput);
    }

    private void GetPlayerControllerIfNull()
    {
        if (playerController == null)
        {
            playerController = playerView.GetPlayerController();
        }
    }

    private void GetPlayerInputServiceIfNull()
    {
        if(playerController != null && currentInputService == null)
        {
            currentInputService = playerController.CurrentInputService;
            SubscribeToInputEvents();
        }
    }

    private void SubscribeToInputEvents()
    {
        currentInputService.OnJumpButtonPressedEvent += OnJumpButtonPressed;
        currentInputService.OnFireButtonPressedEvent += OnFireButtonPressed;
    }

    public void OnJumpButtonPressed()
    {
        playerController.PlayerJumpPressed();
    }

    public void OnFireButtonPressed()
    {
        playerController.PlayerFirePressed();
    }

    private void OnDestroy()
    {
        currentInputService.OnJumpButtonPressedEvent -= OnJumpButtonPressed;
        currentInputService.OnFireButtonPressedEvent -= OnFireButtonPressed;
    }
}
