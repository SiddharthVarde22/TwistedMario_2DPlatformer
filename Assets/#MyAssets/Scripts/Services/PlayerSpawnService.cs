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

    public void SetInputService(InputService inputService)
    {
        this.inputService = inputService;
    }

    public void CreatePlayer(InputService inputService)
    {
        PlayerController playerController = new PlayerController(playerModelScriptable, playerView, inputService);
    }
}
