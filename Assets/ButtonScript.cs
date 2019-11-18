using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void TogglePanelDown()
    {
        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            bool isOpen = animator.GetBool("show");
            if (isOpen)
            {
                animator.SetBool("show", !isOpen);
            }
        }
    }
}
