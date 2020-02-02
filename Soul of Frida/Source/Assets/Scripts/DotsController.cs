using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotsController : MonoBehaviour
{
    public GameObject dot1;
    public GameObject dot2;
    public GameObject dot3;
    public GameObject dot4;
    float pressedSpaceTime;

    void Start()
    {
        dot1.SetActive(false);
        dot2.SetActive(false);
        dot3.SetActive(false);
        dot4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

            dot1.SetActive(true);
            pressedSpaceTime = Time.time;
            if (pressedSpaceTime > 0.4f)
            {
                dot2.SetActive(true);
                dot1.SetActive(false);
                dot3.SetActive(false);
                dot4.SetActive(false);

            }
            if (pressedSpaceTime > 0.8f)
            {
                dot3.SetActive(true);
                dot1.SetActive(false);
                dot2.SetActive(false);
                dot4.SetActive(false);

            }
            if (pressedSpaceTime > 1.2f)
            {
                dot4.SetActive(true);
                dot1.SetActive(false);
                dot3.SetActive(false);
                dot2.SetActive(false);

            }
            if (pressedSpaceTime > 1.6f)
            {
                dot4.SetActive(false);
            }
        


    }
}
