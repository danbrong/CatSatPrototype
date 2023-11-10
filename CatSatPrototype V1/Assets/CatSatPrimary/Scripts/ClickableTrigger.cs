using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickableTrigger : MonoBehaviour
{
    // Variable Declaration
    private int counter = 0;
    public GameObject player;
    public GameObject self;
    public Button clickableMsg;

    void OnTriggerEnter(Collider other)
    {
        if (player && counter == 1)
        {
            clickableMsg.gameObject.SetActive(true);
        }
        else if (player && counter == 0 || counter == 2)
        {
            clickableMsg.gameObject.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (player)
        {
            clickableMsg.gameObject.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        counter++;
        Debug.Log("You Clicked an Item!");
        Debug.Log(counter);
        
        if (counter > 1)
        {
            counter = 0;
        }
        
    }
}
