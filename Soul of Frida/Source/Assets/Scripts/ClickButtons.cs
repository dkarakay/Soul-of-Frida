using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ClickButtons : MonoBehaviour
{
    public Text lastText;
    public Text btnText;
    public GameObject extraText;
    int total = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        total = PlayerPrefs.GetInt("tear") + PlayerPrefs.GetInt("zoom") + PlayerPrefs.GetInt("swipe");

        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        if (sceneName == "SecondLevel")
        {
            if (total >= 2)
            {
                btnText.text = "Next";
                extraText.SetActive(true);

                lastText.text = "Frida is thankful to you!";
            }
            else
            {
                extraText.SetActive(false);
                btnText.text = "Try Again";
                lastText.text = "Frida is disappointed in you!";
            }
        }
        else
        {
            if (total >= 2)
            {
                btnText.text = "Next Level";
                extraText.SetActive(true);

                lastText.text = "Frida is thankful to you!";
            }
            else
            {
                extraText.SetActive(false);
                btnText.text = "Try Again";
                lastText.text = "Frida is disappointed in you!";
            }
        }

    }

 

    public void nextLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        if (sceneName == "SecondLevel")
        {
            if (total >= 2)
            {
                SceneManager.LoadScene("CreditsScene");
            }
            else
            {
                SceneManager.LoadScene("MainScene");

            }
        }
        else
        {
            if (total >= 2)
            {
                SceneManager.LoadScene("SecondLevel");
            }
            else
            {
                SceneManager.LoadScene("MainScene");

            }
        }
    }
}
