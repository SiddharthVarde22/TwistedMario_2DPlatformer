using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IWeapon
{
    //[SerializeField]
    // bullet projectile

    public void OnWeaponFired()
    {
        //shoot the bullet
        Debug.Log("Spawn bullet");
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
