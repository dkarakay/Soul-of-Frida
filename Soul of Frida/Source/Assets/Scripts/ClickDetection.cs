using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour
{
    public GameObject buyutec, firca, buyuk_firca;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);
            if (cubeHit.collider)
            {
                if (cubeHit.collider.name == "Buyutec") {
              
                        firca.SetActive(true);
                        PlayerPrefs.SetInt("firca", -1);
                    firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                    buyuk_firca.SetActive(true);
                        PlayerPrefs.SetInt("buyuk_firca", -1);
                        buyuk_firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);

                    
                }

                else if (cubeHit.collider.name == "Firca")
                {
                
                        buyutec.SetActive(true);
                        PlayerPrefs.SetInt("buyutec", -1);
                        buyutec.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                    buyuk_firca.SetActive(true);
                        PlayerPrefs.SetInt("buyuk_firca", -1);
                    buyuk_firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                }

                else if (cubeHit.collider.name == "BuyukFirca")
                {
                   
                        buyutec.SetActive(true);
                        PlayerPrefs.SetInt("buyutec", -1);
                    buyutec.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                    firca.SetActive(true);
                        PlayerPrefs.SetInt("firca", -1);
                    firca.GetComponentsInChildren<SpriteRenderer>()[1].color = new Color(0, 0, 0, 0.5f);


                }
            }
        }*/
    }
}
