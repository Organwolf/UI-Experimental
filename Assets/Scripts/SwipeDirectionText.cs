using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeDirectionText : MonoBehaviour
{
    [SerializeField] Text directionText;

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe; 
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        SwipeDirection direction = data.Direction;

        // swiped right
        directionText.text = "SWIPE DIRECTION: " + direction.ToString() + "\n" + "END POSITION: " + data.EndPosition;
    }
}
