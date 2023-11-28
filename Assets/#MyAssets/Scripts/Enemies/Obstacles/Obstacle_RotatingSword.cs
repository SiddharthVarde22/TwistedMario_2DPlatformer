using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_RotatingSword : MonoBehaviour, IObstacle
{
    [SerializeField]
    float rotationSpeed = 180;

    private void Update()
    {
        RotateObstacle();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerView playerView;
        if(collision.gameObject.TryGetComponent<PlayerView>(out playerView))
        {
            OnCollidedWithPlayer(playerView);
        }
    }

    public void OnCollidedWithPlayer(PlayerView playerView)
    {
        playerView.OnCollidedWithObstacle();
    }

    private void RotateObstacle()
    {
        transform.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime * Vector3.forward);
    }
}
