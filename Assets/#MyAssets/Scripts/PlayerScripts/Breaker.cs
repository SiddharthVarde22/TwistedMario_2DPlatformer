using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IBreakable breakableObject;
        if(collision.gameObject.TryGetComponent<IBreakable>(out breakableObject))
        {
            breakableObject.OnObjectBroken();
        }
    }
}
