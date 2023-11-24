using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    PlayerModel playerModelScriptable;
    PlayerView playerView;
    public InputService CurrentInputService { get; private set; }
    public EventService eventService { get; private set; }

    public PlayerController(PlayerModelScriptable playerModelScriptable, PlayerView playerView, InputService inputService, EventService eventService)
    {
        this.CurrentInputService = inputService;
        this.eventService = eventService;
        this.playerModelScriptable = new PlayerModel(playerModelScriptable, this);
        this.playerView = GameObject.Instantiate<PlayerView>(playerView);
        this.playerView.SetPlayerController(this);
        this.eventService.TriggerOnPlayerSpawnedEvent(this);
    }

    public void MovePlayerHorizontal(float horizontalInput)
    {
        playerView.MovePlayerHorizontally(horizontalInput, playerModelScriptable.playerModelScriptable.playerSpeed);
    }

    public void PlayerJumpPressed()
    {
        playerView.MakePlayerJump(playerModelScriptable.playerModelScriptable.playerJumpStrength);
    }

    public void PlayerFirePressed()
    {
        playerView.MakePlayerShoot();
    }

    public PlayerView GetPlayerView()
    {
        return playerView;
    }
}
