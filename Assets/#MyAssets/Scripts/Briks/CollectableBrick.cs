using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBrick : MonoBehaviour, ICollectable
{
    int pointsToBecollected = 10;
    [SerializeField]
    Sprite collectedBrickSprite;

    [SerializeField]
    SpriteRenderer spriteRenderer;

    public void OnObjectCollected()
    {
        pointsToBecollected--;

        if(pointsToBecollected <= 0)
        {
            ChangeTheSrite();
        }
    }

    private void ChangeTheSrite()
    {
        spriteRenderer.sprite = collectedBrickSprite;
        Destroy(this);
    }
}
