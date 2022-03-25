using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    private Animator anim;
    public static int currentFrame = 0;
    public static int accessToQuestion = 6;

    public bool isQuestActive;

    public Button nextButtonUI;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        CheckIfQuestionActive();

        if (isQuestActive) 
        {
            nextButtonUI.interactable = false;
        }
        else 
        {
            nextButtonUI.interactable = true;
        }
    }
    
    //!---FUNCTIONS FOR BUTTONS--------------------------------------
    public void NextFrame() 
    {
        if (currentFrame >= accessToQuestion) 
        {
            currentFrame = 0;
            SetIsNotNext();
            SceneManager.LoadScene(0);
        }
        else 
        {
            currentFrame++;
        }
        
        SetAnimation(); 
        SetIsNext();
    }

    public void PreviousFrame() 
    {
        if (currentFrame <= 0) 
        {
            //currentFrame = 0;
            SceneManager.LoadScene(0);
        }
        else 
        {
            currentFrame--;
        }

        SetAnimation();
        SetIsNotNext();
    }
    //!--------------------------------------------------------------

    private void SetAnimation() => anim.SetInteger("currentFrame", currentFrame);

    private void SetIsNext() => anim.SetBool("isNext", true);

    private void SetIsNotNext() => anim.SetBool("isNext", false);

    private void CheckIfQuestionActive() 
    {   
        GameObject questObj = GameObject.FindGameObjectWithTag("Question");


        if (questObj == null)
        {
            isQuestActive = false;
        }
        else if (questObj != null) 
        {
            isQuestActive = true;
        }
    }
}
