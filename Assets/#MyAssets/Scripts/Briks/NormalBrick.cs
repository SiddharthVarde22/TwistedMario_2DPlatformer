using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBrick : MonoBehaviour, IBreakable
{
    public void OnObjectBroken()
    {
        Destroy(gameObject, 0.1f);
    }
}
