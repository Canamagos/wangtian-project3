using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjInteraction : MonoBehaviour
{
    public float interactDistance = 3f; // Maximum distance to interact
    public Camera playerCamera; // Assign the player's camera in the Inspector
    public GameObject canInteractUi; // UI element to show when can interact

    void Update()
    {
        // Cast a ray from the camera forward
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            // Check if the object has the "Interactible" tag
            if (hit.collider.CompareTag("Interactible"))
            {
                canInteractUi.SetActive(true); // Show UI
                // If R key is pressed, interact
                if (Input.GetKeyDown(KeyCode.R))
                {
                    Destroy(hit.collider.gameObject);
                    //interact with the object
                    Debug.Log("Interacted with " + hit.collider.name);
                }
                return; // Exit to avoid hiding UI immediately
            }
            canInteractUi.SetActive(false); // Hide UI if not looking at interactible
        }
    }
}
