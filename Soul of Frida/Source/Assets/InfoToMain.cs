using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoToMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Foo());
    }


    IEnumerator Foo()
    {
        // Do something
        yield return new WaitForSeconds(5f);  // Wait three seconds
        SceneManager.LoadScene("MainScene");
        // Do something else
    }
}