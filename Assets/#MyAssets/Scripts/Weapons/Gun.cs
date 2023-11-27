using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IWeapon
{
    [SerializeField]
    BulletView bulletPrefabToSpawn;
    [SerializeField]
    Transform bulletSpawnPosition;

    public void OnWeaponFired()
    {
        ServiceLocator.Instance.bulletSpawnService.SpawnBullet(bulletSpawnPosition, bulletPrefabToSpawn);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerView playerView;
        if(collision.TryGetComponent<PlayerView>(out playerView))
        {
            playerView.CollectTheWeapon(this);
        }
    }
}
