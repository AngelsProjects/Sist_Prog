using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animacion : MonoBehaviour
{
    public Animation anim;
    bool flag = false;
    private void Start()
    {
        anim = GetComponent<Animation>();
       // anim.CrossFade("Idle");
    }
    private void Update()
    {
        
        if (this.GetComponent<moveRandomly>().nav.remainingDistance!=Mathf.Infinity&&
            this.GetComponent<moveRandomly>().nav.pathStatus==NavMeshPathStatus.PathComplete&&
            this.GetComponent<moveRandomly>().nav.remainingDistance==0&&
            !flag)
        {
      //      anim.CrossFade("Idle");
            Debug.Log("ya llegue prro");
            flag = true;
        }
        else
        {
        //    anim.CrossFade("Walk");
            flag = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name=="muere")
        {
            Debug.Log("te vas a morir prro!!");
            Destroy(other.gameObject);
        }
        //Destroy(this.gameObject);
       // Debug.Log("entro el objeto: "+this.name);
    }
    void OnCollisionEnter(Collision collision)
    {
      //  Debug.Log("ENTRO A ESTA MADRE: "+this.name);
    }
}
