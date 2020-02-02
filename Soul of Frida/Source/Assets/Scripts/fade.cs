using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    private SpriteRenderer s;
    bool a = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        s = GetComponent<SpriteRenderer>();
        // Start a coroutine to fade the material to zero alpha over 3 seconds.
        // Caching the reference to the coroutine lets us stop it mid-way if needed.
        if (a)
        {
            StartCoroutine(FadeTo(1f, 0.8f));
        }

    }
    // Define an enumerator to perform our fading.
    // Pass it the material to fade, the opacity to fade to (0 = transparent, 1 = opaque),
    // and the number of seconds to fade over.
    IEnumerator FadeTo(float targetOpacity, float duration)
    {

        // Cache the current color of the material, and its initiql opacity.
        Color color = s.color;
        float startOpacity = color.a;

        // Track how many seconds we've been fading.
        float t = 0;

        while (t < duration)
        {
            // Step the fade forward one frame.
            t += Time.deltaTime;
            // Turn the time into an interpolation factor between 0 and 1.
            float blend = Mathf.Clamp01(t / duration);

            // Blend to the corresponding opacity between start & target.
            color.a = Mathf.Lerp(startOpacity, targetOpacity, blend);

            // Apply the resulting color to the material.
            s.color = color;

            // Wait one frame, and repeat.
            yield return null;
        }
        a = false;
    }
}
