using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeAnimation : MonoBehaviour
{

	[SerializeField] GameObject panel;
    [SerializeField] float threshold = 120f;



    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
        Debug.Log("Resolution: " + Screen.currentResolution);
        Debug.Log("Height: " + Screen.height);
        threshold = Screen.height / 10;

    }

    private void SwipePanelUp()
	{
        if(panel != null)
		{
			Animator animator = panel.GetComponent<Animator>();
            if(animator != null)
			{
				bool isOpen = animator.GetBool("open");
                if(!isOpen)
                {
				    animator.SetBool("open", !isOpen);
                }
			}
		}
	}

    private void SwipePanelDown()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                if (isOpen)
                {
                    animator.SetBool("open", !isOpen);
                }
            }
        }
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {

        SwipeDirection direction = data.Direction;

        // limit the area where you can swipe inside the if statement
        if(direction == SwipeDirection.Up && data.EndPosition.y < threshold)
        {
			// if panel closed open it otherwise do nothing
			SwipePanelUp();
		}
		else if(direction == SwipeDirection.Down)
		{
            SwipePanelDown();
		}
    }
}
