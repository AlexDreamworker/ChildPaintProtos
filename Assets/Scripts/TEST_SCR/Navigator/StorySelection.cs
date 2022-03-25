using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorySelection : MonoBehaviour
{
    public int storySwitch = 0;

    private void Start()
    {
        SelectStory();
    }

    void SelectStory() 
    {
        int i = 0;
        foreach (Transform story in transform) 
        {
            if (i == storySwitch)
                story.gameObject.SetActive(true);
            else 
                story.gameObject.SetActive(false);
            i++;
        }
    }

    //?___BUTTON_FOR_CHANGE_STORY_____________________________
    public void NextStory() 
    {
        if (storySwitch >= transform.childCount -1) 
        {
            storySwitch = 0;
        }
        else 
        {
            storySwitch++;
        }
        SelectStory();
    }

    public void PreviousStory() 
    {
        if (storySwitch <= 0) 
        {
            storySwitch = transform.childCount -1;
        }
        else 
        {
            storySwitch--;
        }
        SelectStory();
    }
    //?_______________________________________________________
}
