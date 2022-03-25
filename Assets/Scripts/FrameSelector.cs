using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameSelector : MonoBehaviour
{   
    public GameObject[] frames;

    public Text count, size;

    private int elementsOfFrames = 0;

    private int sizeOfFrames, lenForScroll;

    private GameObject currentFrame;

    private void Awake()
    {
        sizeOfFrames = frames.Length;
        lenForScroll = sizeOfFrames - 1;
        FrameChanger();
    }
 
    private void Update()
    {
        PlayerInputHandler();
    }

    public void NextFrame() 
    {
        if (elementsOfFrames < lenForScroll) 
            elementsOfFrames++;
        if (elementsOfFrames > lenForScroll) 
            elementsOfFrames = lenForScroll;

        FrameChanger();
    }

    public void PreviousFrame() 
    {
        if (elementsOfFrames > 0) 
            elementsOfFrames--;
        if (elementsOfFrames < 0) 
            elementsOfFrames = 0;

        FrameChanger();
    }

    private void FrameChanger() 
    {
        for (int el = 0; el < sizeOfFrames; el++) 
        {
            frames[el].SetActive(false);
        }

        currentFrame = frames[elementsOfFrames];
        currentFrame.SetActive(true);

        count.text = (elementsOfFrames + 1).ToString();
        size.text = sizeOfFrames.ToString();
    }

    private void PlayerInputHandler() 
    {
        if (Input.mouseScrollDelta.y > 0)
            NextFrame();
        if (Input.mouseScrollDelta.y < 0)
            PreviousFrame();
    }
}
