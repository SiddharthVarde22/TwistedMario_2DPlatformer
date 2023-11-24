using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IBreakable breakableObject;
        if (collision.gameObject.TryGetComponent<IBreakable>(out breakableObject))
        {
            breakableObject.OnObjectBroken();
        }
    }
}
