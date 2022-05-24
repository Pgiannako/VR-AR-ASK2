using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchLink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider != null)
                {
                    GameObject touchedObject = hit.transform.gameObject;
                    // wikipedia links
                    if (touchedObject.tag == "gabe")
                    {
                        Application.OpenURL("https://en.wikipedia.org/wiki/Gabe_Newell");
                    }
                    else if(touchedObject.tag == "ronaldo")
                    {
                        Application.OpenURL("https://en.wikipedia.org/wiki/Cristiano_Ronaldo");
                    }
                    else if (touchedObject.tag == "lewis")
                    {
                        Application.OpenURL("https://en.wikipedia.org/wiki/Lewis_Hamilton");
                    }
                    else if (touchedObject.tag == "beyonce")
                    {
                        Application.OpenURL("https://en.wikipedia.org/wiki/Beyonc%C3%A9");
                    }
                    else if (touchedObject.tag == "john")
                    {
                        Application.OpenURL("https://en.wikipedia.org/wiki/John_Wick");
                    }
                    else if (touchedObject.tag == "freddie")
                    {
                        Application.OpenURL("https://en.wikipedia.org/wiki/Freddie_Mercury");
                    }
                    // object links
                    else if (touchedObject.tag == "ball")
                    {
                        Application.OpenURL("https://www.cristianoronaldo.com/#cr7");
                    }
                    else if (touchedObject.tag == "valve")
                    {
                        Application.OpenURL("https://store.steampowered.com/");
                    }
                    else if (touchedObject.tag == "car")
                    {
                        Application.OpenURL("https://www.formula1.com/en/drivers/lewis-hamilton.html");
                    }
                    else if (touchedObject.tag == "gun")
                    {
                        Application.OpenURL("https://www.imdb.com/title/tt2911666/?ref_=fn_al_tt_1");
                    }
                    else if (touchedObject.tag == "micB")
                    {
                        Application.OpenURL("https://www.youtube.com/c/beyonce");
                    }
                    else if (touchedObject.tag == "micF")
                    {
                        Application.OpenURL("https://www.youtube.com/channel/UCiMhD4jzUqG-IgPzUmmytRQ");
                    }

                }
            }
        }
    }
}
