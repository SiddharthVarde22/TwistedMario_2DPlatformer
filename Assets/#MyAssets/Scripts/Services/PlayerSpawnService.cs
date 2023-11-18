using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnService : MonoBehaviour
{
    [SerializeField]
    PlayerView playerView;
    [SerializeField]
    PlayerModelScriptable playerModelScriptable;

    private void Awake()
    {
        PlayerController playerController = new PlayerController(playerModelScriptable, playerView);
    }
}
