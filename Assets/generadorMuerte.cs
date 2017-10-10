using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorMuerte : MonoBehaviour
{
    public int cantidad;
    public GameObject calaca;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {
            //Transform spawningpos = new Vector3(Random.Range(-40, 38), 5, Random.Range(-35, 35));
            switch (Random.Range(0, 3))
            {
                case 0:
                    Instantiate(calaca, new Vector3(Random.Range(-40, 38), 0, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(0, 0, 0)));
                    break;
                case 1:
                    Instantiate(calaca, new Vector3(Random.Range(-40, 38), 0, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(0, 0, 0)));
                    break;
                case 2:
                    Instantiate(calaca, new Vector3(Random.Range(-40, 38), 0, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(0, 0,0)));
                    break;
                case 3:
                    Instantiate(calaca, new Vector3(Random.Range(-40, 38), 0, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(0, 0, 0)));
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
