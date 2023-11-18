using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    PlayerModelScriptable playerModelScriptable;
    PlayerController playerController;

    public PlayerModel(PlayerModelScriptable playerModelScriptable, PlayerController playerController)
    {
        this.playerController = playerController;
        this.playerModelScriptable = playerModelScriptable;
    }
}
