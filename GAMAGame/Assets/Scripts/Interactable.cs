using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool talks; //If this is true then object can talk to player
    public bool inventory; //If true this object could be put in inventory

    public string message; // the message this object will give the player
    public void DoInteraction()
    {
        //Picked up and put in inventory
        gameObject.SetActive(false);
    }
}
