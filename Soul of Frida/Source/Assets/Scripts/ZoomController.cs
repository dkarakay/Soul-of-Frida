using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoomController : MonoBehaviour
{
    public float transitionSpeed = 0.3f;
    public float desiredCameraSize;
    private Camera cam;
    // Start is called before the first frame update
    public Texture2D cursorArrow;
    public Texture2D cursorPickaxe;

    public GameObject puzzles,hold,buyutec_wrong,buyutec_correct,firca,buyuk_firca;

    bool ok = false, clicked = false,finishHold = true;
    bool puzzleDone = false;
    public GameObject black,buyutec;

    public Collider2D buyutec_coll;

    Ray ray;
    RaycastHit hit;
    void Start()
    {
        cam = Camera.main;
        desiredCameraSize = cam.orthographicSize;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);

    }

    void Update()
    {
        

        if (puzzleDone) {
            cam.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5f, transitionSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(0, 0, -10), transitionSpeed);

            puzzles.SetActive(false);


        }
        if (ok)
        {
            Scene currentScene = SceneManager.GetActiveScene();

            // Retrieve the name of this scene.
            string sceneName = currentScene.name;
            if (sceneName == "MainScene")
            {

                cam.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 1.5f, transitionSpeed);
                cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f, -10), transitionSpeed);
                if (Mathf.Abs(cam.transform.position.x) < Mathf.Abs(gameObject.transform.position.x) && Mathf.Abs(cam.transform.position.x) > Mathf.Abs(gameObject.transform.position.x)/2)
                {
                    puzzles.SetActive(true);
                }
            }
            else {
                cam.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 2.5f, transitionSpeed);
                cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f, -10), transitionSpeed);
                if (Mathf.Abs(cam.transform.position.x) < Mathf.Abs(gameObject.transform.position.x) && Mathf.Abs(cam.transform.position.x) > Mathf.Abs(gameObject.transform.position.x) / 2)
                {
                    puzzles.SetActive(true);
                }
            }

        }
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

            if (cubeHit.collider)
            {

                if (cubeHit.collider.name == "Zoom" && !clicked && PlayerPrefs.GetInt("buyutec") == 1)
                {


                    Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
                    PlayerPrefs.SetInt("buyutec", 0);
                    buyutec.SetActive(true);
                    buyutec.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);
                    clicked = true;
                    ok = true;

                }
                else if (cubeHit.collider.name == "CorrectPuzzle")
                {
                    puzzles.SetActive(false);
                    ok = false;
                    black.SetActive(false);
                    puzzleDone = true;
                    buyutec_correct.SetActive(true);
                    PlayerPrefs.SetInt("zoom", 1);
                    PlayerPrefs.SetInt("buyutec", 0);
                    buyutec_coll.enabled = false;



                }
                else if (cubeHit.collider.name == "WrongPuzzle1")
                {
                    //puzzles.SetActive(false);
                    GameObject go = GameObject.Find("WrongPuzzle1");
                    Instantiate(go, black.transform.position, black.transform.rotation);
                    ok = false;
                    black.SetActive(false);
                    puzzleDone = true;
                    buyutec_wrong.SetActive(true);
                    PlayerPrefs.SetInt("buyutec", 0);
                    PlayerPrefs.SetInt("zoom", 0);
                    buyutec_coll.enabled = false;


                }

                else if (cubeHit.collider.name == "WrongPuzzle2")
                {
                    //puzzles.SetActive(false);
                    GameObject go = GameObject.Find("WrongPuzzle2");
                    Instantiate(go, black.transform.position, black.transform.rotation);
                    ok = false;
                    black.SetActive(false);
                    puzzleDone = true;
                    buyutec_wrong.SetActive(true);
                    PlayerPrefs.SetInt("buyutec", 0);
                    PlayerPrefs.SetInt("zoom", 0);
                    buyutec_coll.enabled = false;



                }
                else if (cubeHit.collider.name == "white")
                {
                    if (PlayerPrefs.HasKey("buyuk_firca") && PlayerPrefs.GetInt("buyuk_firca") == 1)
                    {
                        PlayerPrefs.SetInt("buyuk_firca",2);
                        Scene currentScene = SceneManager.GetActiveScene();

                        // Retrieve the name of this scene.
                        string sceneName = currentScene.name;

                        if (sceneName == "MainScene")
                        {
                            hold.SetActive(true);
                        }
                    }
                }
                if (cubeHit.collider.name == "Buyutec")
                {

                    firca.SetActive(true);
                    PlayerPrefs.SetInt("firca", -1);
                    firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                    buyuk_firca.SetActive(true);
                    PlayerPrefs.SetInt("buyuk_firca", -1);
                    buyuk_firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                }

                 if (cubeHit.collider.name == "Firca")
                {

                    buyutec.SetActive(true);
                    PlayerPrefs.SetInt("buyutec", -1);
                    buyutec.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                    buyuk_firca.SetActive(true);
                    PlayerPrefs.SetInt("buyuk_firca", -1);
                    buyuk_firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                }

                 if (cubeHit.collider.name == "BuyukFirca")
                {

                    buyutec.SetActive(true);
                    PlayerPrefs.SetInt("buyutec", -1);
                    buyutec.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                    firca.SetActive(true);
                    PlayerPrefs.SetInt("firca", -1);
                    firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                }


            }
            // Reset ray with new mouse position
            /*ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("MouseDown");

                if (hit.collider.gameObject.name == "Zoom")
                {*/
            /* cam.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 1.5f, transitionSpeed);
             cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(-2, 3, -10), transitionSpeed);
             if (cam.transform.position.x > -2 && cam.transform.position.x < -1.5)
             {
                 puzzles.SetActive(true);
             }*/
            //}



        }
    }

        public void ZoomCamera(float size)
    {
        desiredCameraSize = size;
    }


    void OnMouseEnter()
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
            if (!clicked && PlayerPrefs.GetInt("buyutec") != 1)
            {
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

