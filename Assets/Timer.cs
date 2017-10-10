using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text counterText;
    public Text texto;
    public float seconds, minutes,total=0;
    float vida;
    // Use this for initialization
    void Start()
    {
        vida = 60f;
        counterText = GetComponent<Text>() as Text;
        // counterText.text = "05:00";
    }

    // Update is called once per frame
    void Update()
    {
        minutes = Time.timeSinceLevelLoad / 60f;
        seconds = Time.timeSinceLevelLoad;
        var res = "";

         total = vida - seconds;
        float sec = total % 60f;
        float minut0 = total / 60f;
        if (total % 60f==0)
        {
            res = minut0.ToString("00") + ":00";
        }
        else
        {
           
            res = minut0.ToString("00") + ":" + sec.ToString("00");
        }
        if (total<60)
        {
            res = "00:" + sec.ToString("00");
        }
        if (total==60)
        {
            res = "01:00";
        }
        if (total < 15)
        {
            counterText.color = Color.red;
            texto.color = Color.red;
        }
        if (total>60)
        {
            res = minut0.ToString("00") + ":" + sec.ToString("00");
        }

        if (minutes >= 5)
        {
            Destroy(GameObject.Find("Canvas"));
            SceneManager.LoadScene(2);
            //muere x.X
        }
        counterText.text = res;
        if (total <= 0f)
        {
            Destroy(GameObject.Find("Canvas"));
            SceneManager.LoadScene(2);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Debug.Log("ENTRO A ESTA : " + collision.gameObject.name);
        switch (hit.gameObject.tag)
        {
            case "manzana":
                Debug.Log("ENTRO A ESTA : " + hit.gameObject.name);
                Destroy(hit.gameObject);
                vida = vida + 60;
                break;
            //case "muere":
            //    Debug.Log("ENTRO A ESTA : " + hit.gameObject.name);
            //    Destroy(hit.gameObject);
            //    break;
            //case "muerte":
            //    Debug.Log("ENTRO A ESTA : " + hit.gameObject.name);

            //    Destroy(hit.gameObject);
            //    Destroy(GameObject.Find("Canvas"));
            //    SceneManager.LoadScene(2);
            //    break;
        }
    }

    }
