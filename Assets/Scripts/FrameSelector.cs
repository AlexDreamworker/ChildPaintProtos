using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameSelector : MonoBehaviour
{   
    public GameObject[] frames;

    public Text count, size;

    [HideInInspector] public int elementsOfFrames = 0;
    [HideInInspector] public int sizeOfFrames;

    private GameObject currentFrame;

    private void Awake()
    {
        sizeOfFrames = frames.Length;
    }
 
    private void Update()
    {
        count.text = (elementsOfFrames + 1).ToString();
        size.text = sizeOfFrames.ToString();

        for (int el = 0; el < sizeOfFrames; el++) 
        {
            frames[el].SetActive(false);
        }
        currentFrame = frames[elementsOfFrames];
        currentFrame.SetActive(true);

        int lenForScroll = frames.Length-1;

        if (Input.mouseScrollDelta.y > 0 && elementsOfFrames < lenForScroll) 
            elementsOfFrames++;
        if (elementsOfFrames > lenForScroll) 
            elementsOfFrames = lenForScroll;
            
        if (Input.mouseScrollDelta.y < 0 && elementsOfFrames > 0) 
            elementsOfFrames--;
        if (elementsOfFrames < 0) 
            elementsOfFrames = 0;
    }

}
