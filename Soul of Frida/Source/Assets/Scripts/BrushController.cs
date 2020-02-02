using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushController : MonoBehaviour
{
    public Texture2D cursorArrow;


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && PlayerPrefs.GetInt("firca") == -1)
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);
            if (cubeHit.collider)
            {
                if (cubeHit.collider.name == "Firca")
                {
                    Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
                    PlayerPrefs.SetInt("firca", 1);
                    PlayerPrefs.SetInt("cursor", 1);
                    gameObject.SetActive(false);


                }
            }
        }

    }
}
