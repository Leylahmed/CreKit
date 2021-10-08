using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animation playerAnimationComponent;

    [SerializeField] private float swipeDistance;

    private Vector2 initialMousePos;

    private bool isScreenPressed = false;

    private SwipeDirection currentPlayerDirection;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(isScreenPressed == false && Input.GetMouseButtonDown(0))
        {
            isScreenPressed = true;

            initialMousePos = Input.mousePosition;
        }

        if(isScreenPressed == true && Input .mousePosition .y >= initialMousePos .y + swipeDistance)
        {
            currentPlayerDirection = SwipeDirection.UP;
            Debug.Log(currentPlayerDirection);
            isScreenPressed = false;
        }
        else if(isScreenPressed==true && Input.mousePosition.y <= initialMousePos.y - swipeDistance)
        {
            currentPlayerDirection = SwipeDirection.DOWN;
            Debug.Log(currentPlayerDirection);
            isScreenPressed = false;
        }

        else if (isScreenPressed == true && Input.mousePosition.x >= initialMousePos.x + swipeDistance)
        {
            currentPlayerDirection = SwipeDirection.RIGHT;
            Debug.Log(currentPlayerDirection);
            isScreenPressed = false;
        }

        else if (isScreenPressed == true && Input.mousePosition.x <= initialMousePos.x - swipeDistance)
        {
            currentPlayerDirection = SwipeDirection.LEFT;
            Debug.Log(currentPlayerDirection);
            isScreenPressed = false;
        }
    }

}
public enum SwipeDirection { LEFT, RIGHT, UP, DOWN };
