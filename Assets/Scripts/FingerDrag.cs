using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerDrag : MonoBehaviour
{
    public Camera mainCamera;

    private void Update()
    {
        if (Input.touchCount == 1) // if there is a touch
        {
            Touch touch = Input.touches[0];
            Vector3 touchPosition = mainCamera.ScreenToWorldPoint(touch.position);  //calculating touch position in the world space
            touchPosition.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, touchPosition, 30 * Time.deltaTime);
        }

        if (Input.GetMouseButton(0)) //if mouse button was pressed 
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition); //calculating mouse position in the worldspace
            mousePosition.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, 30 * Time.deltaTime);
        }
    }
}


