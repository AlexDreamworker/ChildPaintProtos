using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryToGo : MonoBehaviour
{
    public int indexOfStory;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(indexOfStory);
    }
}
