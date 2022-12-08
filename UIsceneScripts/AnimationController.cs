using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    
    public Animator anim;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetTrigger("Close");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            anim.SetTrigger("Open");
        }
    }
    
}
