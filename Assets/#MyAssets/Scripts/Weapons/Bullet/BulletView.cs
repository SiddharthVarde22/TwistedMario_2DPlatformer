using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour, IDamager
{
    [SerializeField]
    float forceToAdd = 10;
    [SerializeField]
    Rigidbody2D bulletRigidBody;
    [SerializeField]
    float lifeTime = 3f;

    float currentTime;
    PlayerView owningPlayer;

    public void EnableBullet(Transform initialTransform, PlayerView playerView)
    {
        transform.SetPositionAndRotation(initialTransform.position, initialTransform.rotation);
        gameObject.SetActive(true);
        bulletRigidBody.AddForce(forceToAdd * transform.right, ForceMode2D.Impulse);
        currentTime = 0;
        this.owningPlayer = playerView;
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= lifeTime)
        {
            DisableBullet();
        }
    }

    public void DisableBullet()
    {
        ServiceLocator.Instance.bulletSpawnService.ReturnBullet(this);
        bulletRigidBody.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DisableBullet();
    }

    public void OnDamagePerformed()
    {
        owningPlayer.OnEnemyKilled();
    }
}
