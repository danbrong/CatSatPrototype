using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFeedbackFade : MonoBehaviour
{
    // Variable Declaration
    public GameObject icon; // track the Click preFab
    public float fadeSpeed; // adjust rate of Fade
    public float destroyAfter; // adjust time before Object destroys itself

    // Update is called once per frame
    void Update()
    {
        // Begin fade out routine and destroy object after use.
        StartCoroutine(FadeOutObject());
        Destroy(icon,destroyAfter);
    }

    public IEnumerator FadeOutObject()
    {
        // Target object visibility for changes while visibile
        while (this.GetComponent<Renderer>().material.color.a > 0)
        {
            // Target the color trait to fade visiblity
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            // Code to change the visibility over time.
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }
}
