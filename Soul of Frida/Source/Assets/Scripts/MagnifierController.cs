using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifierController : MonoBehaviour
{
    public Texture2D cursorArrow;
    
 


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && PlayerPrefs.GetInt("buyutec") == -1 ) {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (cubeHit.collider.name == "Buyutec") {
                Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
                PlayerPrefs.SetInt("buyutec", 1);
                PlayerPrefs.SetInt("cursor", 0);

                gameObject.SetActive(false);

                
            }
        }
        
    }
}
