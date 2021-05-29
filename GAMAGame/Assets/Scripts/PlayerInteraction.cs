using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    public GameObject currentInteractableObj = null;
    public Interactable currentInteractableObjScript = null;
    public Inventory inventory;

    void Update()
    {
        if (Input.GetButtonDown("Interact") && currentInteractableObj) {

            //Check to see if this object is to be stored in inventory
            if (currentInteractableObjScript.inventory) {
                inventory.AddItem(currentInteractableObj);
            }



            // if (currentInteractableObj.talks)
            // {
            //     Debug.Log("Talking Interaction");
            //     //Tell the object to give its message
            //     currentInteractableObj
            // }
        }
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("interactableObject"))
        {
            Debug.Log(other.name);
            currentInteractableObj = other.gameObject;
            currentInteractableObjScript = currentInteractableObj.GetComponent<Interactable>();
        }
    }

    void OnTriggerExit(Collider other)
    { 
        if (other.CompareTag("interactableObject"))
        {
            if (other.gameObject == currentInteractableObj) 
            {
                currentInteractableObj = null;
            }
        }
    }
}
