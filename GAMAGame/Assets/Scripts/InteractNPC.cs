using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractNPC : MonoBehaviour
{

    public GameObject currentInteractableObj = null;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("interactableObject"))
        {
            Debug.Log(other.name);
            currentInteractableObj = other.gameObject;
        }
    }
}
