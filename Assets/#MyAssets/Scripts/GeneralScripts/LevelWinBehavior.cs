using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWinBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerView playerView = null;

        if(collision.gameObject.TryGetComponent<PlayerView>(out playerView))
        {
            ServiceLocator.Instance.sceneLoader.LoadPlayerWinLevel();
        }
    }
}
