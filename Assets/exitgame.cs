using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitgame : MonoBehaviour
{
    private void Start()
    {
        //Destroy(GameObject.Find("Canvas"));
        Button b = this.GetComponent<Button>();
        b.onClick.AddListener(delegate () { ExitGame(); });
    }
    public void ExitGame()
    {
        Destroy(GameObject.Find("Canvas"));
        Application.Quit();
    }
}
