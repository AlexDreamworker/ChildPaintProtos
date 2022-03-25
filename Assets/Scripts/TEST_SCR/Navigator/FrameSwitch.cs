using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSwitch : MonoBehaviour
{
    public Question question;
    public int frameSwitch = 0;
    public int frameCount = 0;

    private void Start()
    {
        SelectFrame();
    }

    private void Update()
    {
        // CheckQuestion();
    }

    private void SelectFrame() 
    {
        int i = 0;
        foreach (Transform frame in transform)
        {
            if (i == frameSwitch) 
            {
                frame.gameObject.SetActive(true);
            }
            else
            {
                frame.gameObject.SetActive(false);
            }
            i++;
        }
    }

    public void NextFrame() 
    {
        
        if (frameSwitch >= frameCount) 
        {
            frameSwitch = frameCount;
        }
        else 
        {
            frameSwitch++;
        }  
        SelectFrame();       
    }

    public void PreviousFrame() 
    {
        
        if (frameSwitch <= 0) 
        {
            frameSwitch = 0;
        }
        else 
        {
            frameSwitch--;
        }  
        SelectFrame();       
    }

    // private void CheckQuestion() 
    // {
    //     if (Question.QState == 1) 
    //     {
    //         print("YES");
    //     }
    //     else if (Question.QState == 2) 
    //     {
    //         print("NO");
    //     }
    // }
}
