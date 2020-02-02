using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndHold : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0.25f, -0.35f,1),0.05f);

        if (gameObject.transform.position.x > 0.23f) {
            GetComponent<SpriteRenderer>().color = new Color(255,255,255,0);
        }
    }
}
