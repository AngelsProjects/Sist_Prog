using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Debug.Log("rgerdg");
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("rgerdsg");
    }
}
