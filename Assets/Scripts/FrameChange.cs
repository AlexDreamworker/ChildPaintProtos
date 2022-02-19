using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameChange : MonoBehaviour
{
    public GameObject frame1;
    public GameObject frame2;

    public void NextFrame() 
    {
        frame1.SetActive(false);
        frame2.SetActive(true);
    }

    public void PreviousFrame() 
    {
        frame1.SetActive(true);
        frame2.SetActive(false);
    }

    public void Exit() 
    {
        Application.Quit();
    }
}
