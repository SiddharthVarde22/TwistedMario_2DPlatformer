using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    PlayerModel playerModelScriptable;
    PlayerView playerView;

    public PlayerController(PlayerModelScriptable playerModelScriptable, PlayerView playerView)
    {
        this.playerModelScriptable = new PlayerModel(playerModelScriptable, this);
        this.playerView = GameObject.Instantiate<PlayerView>(playerView);
        this.playerView.SetPlayerController(this);
    }
}
