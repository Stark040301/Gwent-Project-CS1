using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardClickHandler : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Raycast from the mouse position into the scene
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Perform the raycast
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the raycast hit a card GameObject
            if (hit.collider.gameObject == gameObject)
            {
                // This GameObject is the card that was clicked
                Debug.Log("Clicked on card: " + gameObject.name);

                // Now you can do whatever you need with the card GameObject
                // For example, you can access its components, change its properties, etc.
            }
        }
    }
}

