using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject self;
    public Button message;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item Collision!");
        if (player)
        message.gameObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Item Exited!");
        if (player)
        message.gameObject.SetActive(false);
    }
}

