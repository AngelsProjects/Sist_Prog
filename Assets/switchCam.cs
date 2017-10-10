using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class switchCam : MonoBehaviour
{
    public Camera[] cams;
    int longitud;
    int start = 0;
    bool flag = false;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (flag)
            {
                gameObject.GetComponent<NavMeshAgent>().enabled = false;
                gameObject.GetComponent<CharacterController>().enabled = true;
                flag = false;
            }
            else
            {
                gameObject.GetComponent<NavMeshAgent>().enabled = true;
                gameObject.GetComponent<CharacterController>().enabled = false;

                flag = true;
            }
        }
    }
}
