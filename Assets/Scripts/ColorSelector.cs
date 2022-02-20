using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelector : MonoBehaviour
{
    public Color colorChangeButton;

    public void ColorSelecting() 
    {
        ColorManager.S.globalColor = colorChangeButton;
    }
}
