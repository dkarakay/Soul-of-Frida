using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{


    public Texture2D cursorArrow;
    public GameObject white, buyuk_firca,dots,gthick,canvas;
    private float timePressed = 0.0f;
    private float timeLastPress = 0.0f;

    public Collider2D[] disable;
    public Collider2D buyuk_firca_coll;

    bool done = false;
    bool hold = false;

    SpriteRenderer s;
    Vector2 firstPos, lastPos;
    public void Awake()
    {
        PlayerPrefs.SetInt("buyutec", -1);
        PlayerPrefs.SetInt("firca", -1);
        PlayerPrefs.SetInt("buyuk_firca", -1);

        PlayerPrefs.SetInt("swipe", -1);
        PlayerPrefs.SetInt("tear", -1);
        PlayerPrefs.SetInt("zoom", -1);

    }
    private void Start()
    {
        lastPos = new Vector2(10,10);
        s = white.GetComponent<SpriteRenderer>();

    }

    void Update()
    {

        if (PlayerPrefs.GetInt("tear") >= 0 && PlayerPrefs.GetInt("swipe") >= 0 && PlayerPrefs.GetInt("zoom") >= 0) {
            canvas.SetActive(true);
            for (int i = 0; i < disable.Length; i++) {
                disable[i].enabled = false;
            }
        }

    

            if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 2)
        {

            if (!done)
            {

                if (Input.GetMouseButtonDown(0))
                {



                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    firstPos = new Vector2(mousePos.x, mousePos.y);
                }
                if (Input.GetMouseButton(0))
                {
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    lastPos = new Vector2(mousePos.x, mousePos.y);

                    if (lastPos.x > white.GetComponent<SpriteRenderer>().bounds.max.x ||
                        lastPos.x < white.GetComponent<SpriteRenderer>().bounds.min.x ||
                        lastPos.y < white.GetComponent<SpriteRenderer>().bounds.min.y ||
                        lastPos.y > white.GetComponent<SpriteRenderer>().bounds.max.y)
                    {
                        Debug.Log("Error");
                        return;

                    }
                    else
                    {
                    
                        float mesafe = white.transform.position.y - white.GetComponent<SpriteRenderer>().bounds.min.y;
                        mesafe /= 4;
                        mesafe *= 2;


                        if (firstPos.x > white.GetComponent<SpriteRenderer>().bounds.min.x && firstPos.x < white.transform.position.x)
                        {
                            Debug.Log("dfist");


                            if (firstPos.y < white.GetComponent<SpriteRenderer>().bounds.max.y && firstPos.y > white.transform.position.y)
                            {
                                Debug.Log("fdfist");
                                Debug.Log(lastPos.x + " " + white.GetComponent<SpriteRenderer>().bounds.max.x + " f " + white.transform.position.x);


                                if (lastPos.x < white.GetComponent<SpriteRenderer>().bounds.max.x && lastPos.x > white.transform.position.x)
                                {
                                    Debug.Log(lastPos.x + " " + white.GetComponent<SpriteRenderer>().bounds.max.x + " f " + white.transform.position.x);

                                    if (lastPos.y > white.GetComponent<SpriteRenderer>().bounds.min.y && lastPos.y < white.transform.position.y - mesafe)
                                    {
                                        //   Debug.Log("Correct pos 2");
                                        s.color = new Color(255, 255, 255, 0);

                                        PlayerPrefs.SetInt("buyuk_firca", 0);
                                        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
                                        buyuk_firca.SetActive(true);
                                        buyuk_firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);
                                        Debug.Log("Color1");
                                        gthick.SetActive(true);
                                        white.SetActive(false);
                                        PlayerPrefs.SetInt("swipe", 1);
                                        done = true;
                                        buyuk_firca_coll.enabled = false;


                                    }
                                }
                                 


                            }


                        }



                    }



                }
            }
        }
            
        }
 

            
        
   
      

        /*Debug.Log("Center: " + white.transform.position.x + " " + white.transform.position.y);
        Debug.Log("X: " + white.GetComponent<SpriteRenderer>().bounds.max.x +" " + white.GetComponent<SpriteRenderer>().bounds.min.x);
        Debug.Log("Y: " + white.GetComponent<SpriteRenderer>().bounds.max.y + " " + white.GetComponent<SpriteRenderer>().bounds.min.y);
        */

    
}
        /*if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.rigidbody.gameObject == white) {
                SpriteRenderer s = white.GetComponent<SpriteRenderer>();
                s.color = new Color(255,255,255,150);
                   
            }
        }*/

     /*   if (Input.GetMouseButtonDown(0)){
            timePressed = Time.time - timeLastPress;

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.rigidbody.gameObject == white){
            //    SpriteRenderer s = white.GetComponent<SpriteRenderer>();
              //  s.color = new Color(255, 255, 255, 0);

            }
        }
    }



}*/