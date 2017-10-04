using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCam : MonoBehaviour
{
    public Camera[] cams;
    int longitud;
    int start = 0;
    // Use this for initialization
    void Start()
    {
        longitud = cams.Length - 1;
        foreach (Camera cam in cams)
        {
            cam.enabled = false;
        }
        cams[0].enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            cams[start].enabled = false;
            if (start == longitud)
            {
                start = 0;
            }
            else
            {
                start++;
            }
            cams[start].enabled = true;

        }
    }
}
