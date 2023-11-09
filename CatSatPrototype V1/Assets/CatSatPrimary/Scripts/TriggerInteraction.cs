using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject interactable;
    public GameObject message;
    [SerializeField] private bool triggerActive = false;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetMouseButtonDown(0))
        {
            PopUpWindow();
        }

        else if (!triggerActive && Input.GetMouseButtonDown(0))
        {
            ClosePopUp();
        }
    }

    public void PopUpWindow()
    {
        message.SetActive(true);
    }

    public void ClosePopUp()
    {
        message.SetActive(false);
    }
}
