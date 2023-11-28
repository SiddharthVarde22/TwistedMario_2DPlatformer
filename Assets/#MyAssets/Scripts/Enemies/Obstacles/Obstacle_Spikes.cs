using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Spikes : MonoBehaviour, IObstacle
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerView playerView;
        if(collision.TryGetComponent<PlayerView>(out playerView))
        {
            OnCollidedWithPlayer(playerView);
        }
    }

    public void OnCollidedWithPlayer(PlayerView playerView)
    {
        playerView.OnCollidedWithObstacle();
    }
}
