using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changelevel : MonoBehaviour
{
    private void Start()
    {
        Button b = this.GetComponent<Button>();
        b.onClick.AddListener(delegate () { StartGame("main"); });
    }
    public void StartGame(string level)
    {
        Destroy(GameObject.Find("Canvas"));
        SceneManager.LoadScene(level);
     
    }
}
