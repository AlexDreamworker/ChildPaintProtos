using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    static public ColorManager S;
    [HideInInspector] public Color globalColor;

    private void Awake()
    {
        S = this;

        globalColor = Color.white;
    }
}
