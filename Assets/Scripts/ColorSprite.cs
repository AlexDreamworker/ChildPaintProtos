using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSprite : MonoBehaviour
{
    SpriteRenderer rend;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        rend.color = ColorManager.S.globalColor;
    }

}
