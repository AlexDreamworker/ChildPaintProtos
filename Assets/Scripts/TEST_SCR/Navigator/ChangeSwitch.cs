using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSwitch : MonoBehaviour
{
    public GameObject story1;
    private Animator anim;

    public string triggerToChange;

    private void Start()
    {
        anim = story1.GetComponent<Animator>();
    }

    public void OnMouseDown()
    {
        story1.SendMessage("NextFrame");
        anim.SetTrigger(triggerToChange);
    }
}
