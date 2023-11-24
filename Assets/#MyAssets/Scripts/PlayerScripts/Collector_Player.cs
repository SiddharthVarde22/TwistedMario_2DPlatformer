using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector_Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectable collectableObject;
        if (collision.gameObject.TryGetComponent<ICollectable>(out collectableObject))
        {
            collectableObject.OnObjectCollected();
        }
    }
}
