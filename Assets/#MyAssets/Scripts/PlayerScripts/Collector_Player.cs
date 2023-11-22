using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector_Player : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ICollectable collectableObject;
        if(collision.gameObject.TryGetComponent<ICollectable>(out collectableObject))
        {
            collectableObject.OnObjectCollected();
        }
    }
}
