using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject interactable;
    public Button message;
    [SerializeField] private bool triggerActive = false;

    // Update is called once per frame
    void Update()
    {
        if (triggerActive)
        {
            message.gameObject.SetActive(true);
        }
        else
        {
            message.gameObject.SetActive(false);
        }
     
    }
    public void OnTriggerEnter(Collider other)
    {
        triggerActive = true;
    }

    public void OnTriggerExit(Collider other)
    {
        triggerActive = false;
    }
}

