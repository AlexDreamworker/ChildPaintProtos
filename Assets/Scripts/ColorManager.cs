using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    static public ColorManager COLOR;
    [HideInInspector] public Color getGlobalColor;

    private void Awake()
    {
        COLOR = this;

        getGlobalColor = Color.white;
    }
}
