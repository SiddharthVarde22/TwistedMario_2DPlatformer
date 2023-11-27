using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnService
{
    private GenericObjectPool<BulletView> bulletPool = new GenericObjectPool<BulletView>();

    public void SpawnBullet(Transform tranaformToSpawnAt, BulletView bulletViewToSpawn)
    {
        BulletView spawnedBullet = bulletPool.GetObjectFromPool();

        if(spawnedBullet == null)
        {
            spawnedBullet = GameObject.Instantiate<BulletView>(bulletViewToSpawn);
        }

        spawnedBullet.EnableBullet(tranaformToSpawnAt);
    }

    public void ReturnBullet(BulletView bulletView)
    {
        bulletPool.ReturnObjectToPool(bulletView);
    }
}
