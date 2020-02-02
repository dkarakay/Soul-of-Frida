using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearController : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D cursorArrow;
    public Texture2D cursorPickaxe;

    public GameObject color1, color2, tear,colors,firca,firca_correct,firca_wrong;
    public Collider2D firca_coll;
    public SpriteRenderer s;
    public bool tearDone = true;

    void Start()
    {
        // Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("firca") && PlayerPrefs.GetInt("firca") == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);
                if (cubeHit.collider)
                {
                   

                    if (cubeHit.collider.name == "Tear" && tearDone)
                    {
                        colors.SetActive(true);
                        Debug.Log("tear");
                        tearDone = false;
                    }
                    if (cubeHit.collider.name == color1.name)
                    {
                        PlayerPrefs.SetInt("firca", 0);
                        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
                        firca.SetActive(true);
                        firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);
                        colors.SetActive(false);
                        Debug.Log("Color1");
                        firca_correct.SetActive(true);
                        PlayerPrefs.SetInt("tear", 1);
                        firca_coll.enabled = false;
                        tear.SetActive(false);
                    }

                    if (cubeHit.collider.name == color2.name)
                    {
                        PlayerPrefs.SetInt("firca", 0);
                        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
                        firca.SetActive(true);
                        firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);
                        Debug.Log("Color2");
                        colors.SetActive(false);
                        firca_wrong.SetActive(true);
                        PlayerPrefs.SetInt("tear", 0);
                        firca_coll.enabled = false;

                        s.color = new Color(255, 255, 255, 0.2f);

                    }
                }
            }
        }
    }
    void OnMouseEnter()
    {
        if (PlayerPrefs.HasKey("buyutec") && PlayerPrefs.GetInt("buyutec") == 1)
        {

        }else if (PlayerPrefs.HasKey("firca") && PlayerPrefs.GetInt("firca") == 1)
        {

        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 1)
        {

        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 2)
        {

        }
        else
        {
            Debug.Log("asw");

            if (tearDone && gameObject.name == tear.name)
            {
                Debug.Log("Tera");
                Cursor.SetCursor(cursorPickaxe, Vector2.zero, CursorMode.ForceSoftware);

            }
        }
    }

    void OnMouseExit()
    {
        if (PlayerPrefs.HasKey("buyutec") && PlayerPrefs.GetInt("buyutec") == 1)
        {

        }
        else if (PlayerPrefs.HasKey("firca") && PlayerPrefs.GetInt("firca") == 1)
        {
        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 1)
        {

        }
        else if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 2)
        {

        }
        else
        {

            Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        }
        
    }
}
