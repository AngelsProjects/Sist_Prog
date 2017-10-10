using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorManzanas : MonoBehaviour
{
    public int cantidad;
    public GameObject manzana;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {

            switch (Random.Range(0, 3))
            {
                case 0:
                    Instantiate(manzana, new Vector3(Random.Range(-40, 38), 5, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(Random.Range(-360, 360), 0, Random.Range(-360, 360))));
                    break;                                                  
                case 1:                                                    
                    Instantiate(manzana, new Vector3(Random.Range(-40, 38), 5, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(Random.Range(-360, 360), Random.Range(-360, 360), 0)));
                    break;                                                  
                case 2:                                                     
                    Instantiate(manzana, new Vector3(Random.Range(-40, 38), 5, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(0, Random.Range(-360, 360), 0)));
                    break;                                                  
                case 3:                                                     
                    Instantiate(manzana, new Vector3(Random.Range(-40, 38), 5, Random.Range(-35, 35)), Quaternion.Euler(new Vector3(0, 0, Random.Range(-360, 360))));
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
