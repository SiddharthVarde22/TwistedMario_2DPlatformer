using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public PlayerModelScriptable playerModelScriptable;
    private PlayerController playerController;

    public PlayerModel(PlayerModelScriptable playerModelScriptable, PlayerController playerController)
    {
        this.playerController = playerController;
        this.playerModelScriptable = playerModelScriptable;
    }
}
