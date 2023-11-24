using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnService : MonoBehaviour
{
    [SerializeField]
    PlayerView playerView;
    [SerializeField]
    PlayerModelScriptable playerModelScriptable;

    InputService inputService;
    EventService eventService;

    public PlayerController spawnedPlayerController { get; private set; }

    public void SetInputService(InputService inputService)
    {
        this.inputService = inputService;
    }

    public void SetEventService(EventService eventService)
    {
        this.eventService = eventService;
    }

    public void CreatePlayer(InputService inputService)
    {
        spawnedPlayerController = new PlayerController(playerModelScriptable, playerView, inputService, eventService);
    }
}
