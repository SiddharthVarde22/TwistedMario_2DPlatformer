using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Petrolling : MonoBehaviour, IObstacle
{
    [SerializeField]
    float movementSpeed = 2, patrollingDistance = 4;

    float maxXPosition, minXPosition;

    private void Start()
    {
        maxXPosition = transform.position.x + patrollingDistance;
        minXPosition = transform.position.x - patrollingDistance;
    }

    private void Update()
    {
        if(transform.position.x >= maxXPosition)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(transform.position.x <= minXPosition)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        transform.position += movementSpeed * Time.deltaTime * transform.right;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerView playerView = null;
        IDamager damager;

        if(collision.gameObject.TryGetComponent<PlayerView>(out playerView))
        {
            OnCollidedWithPlayer(playerView);
        }
        else if(collision.gameObject.TryGetComponent<IDamager>(out damager))
        {
            damager.OnDamagePerformed();
            Destroy(gameObject);
        }
    }

    public void OnCollidedWithPlayer(PlayerView playerView)
    {
        playerView.OnCollidedWithObstacle();
    }
}
