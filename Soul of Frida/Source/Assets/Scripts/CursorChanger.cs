using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D cursorArrow;
    public Texture2D cursorPickaxe;



    void Start()
    {
        // Cursor.visible = false;
       // Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseEnter()
    {
        if (PlayerPrefs.HasKey("buyutec") && PlayerPrefs.GetInt("buyutec") == 1)
        {
            cursorEnter();

        } else if (PlayerPrefs.HasKey("firca") && PlayerPrefs.GetInt("firca") == 1){
            if (gameObject.name == "WrongColor" || gameObject.name == "CorrectColor")
            {
                Debug.Log("dwa");
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 1);
            }
            cursorEnter();

        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 1)
        {
            cursorEnter();

        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 2)
        {
            cursorEnter();

        }
        else
        {
           
            if (gameObject.name == "WrongPuzzle1" || gameObject.name == "CorrectPuzzle" || gameObject.name == "WrongPuzzle2")
            {
                Debug.Log("lol");

                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 0.5f);
            }
            else if (gameObject.name == "Buyutec")
            {
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 1);

            }
            else if (gameObject.name == "Firca")
            {
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 1);
            }

            else if (gameObject.name == "BuyukFirca")
            {
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 0.5f);
            }
            else
            {
                Cursor.SetCursor(cursorPickaxe, Vector2.zero, CursorMode.ForceSoftware);

            }
        }

    }

    void OnMouseExit()
    {
        if (PlayerPrefs.HasKey("buyutec") && PlayerPrefs.GetInt("buyutec") == 1)
        {
            cursorExit();

        }
        else if (PlayerPrefs.HasKey("firca") && PlayerPrefs.GetInt("firca") == 1){
            if (gameObject.name == "WrongColor" || gameObject.name == "CorrectColor")
            {
                Debug.Log("dwa");
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(162, 160, 163, 0.5f);
            }
            cursorExit();

        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 1)
        {
            cursorExit();

        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 2)
        {
            cursorExit();

        }

        else
        {
            
            if (gameObject.name == "WrongPuzzle1" || gameObject.name == "CorrectPuzzle" || gameObject.name == "WrongPuzzle2")
            {
                Debug.Log("tt");
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(162, 160, 163, 0.5f);

            }
            cursorExit();
            Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        }
    }

    void cursorEnter() {

         if (gameObject.name == "Buyutec")
            {
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 1);

            }
            else if (gameObject.name == "Firca")
            {
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 1);
            }

            else if (gameObject.name == "BuyukFirca")
            {
                gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(111, 0, 0, 0.5f);
            }
    }

    void cursorExit() {
        if (gameObject.name == "Buyutec")
        {
            gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);
        }
        else if (gameObject.name == "Firca")
        {
            gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);
        }
        else if (gameObject.name == "BuyukFirca")
        {
            gameObject.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);
        }
    }
}
