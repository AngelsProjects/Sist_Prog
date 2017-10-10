using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class animacion : MonoBehaviour
{
    Animation anim;
    bool flag = false;
    private void Start()
    {
        //anim = GetComponent<Animation>();

        // anim.Play("cat_Walk");
    }
    private void Update()
    {

        if (this.GetComponent<moveRandomly>().nav.enabled &&
        this.GetComponent<moveRandomly>().nav.remainingDistance != Mathf.Infinity &&
            this.GetComponent<moveRandomly>().nav.pathStatus == NavMeshPathStatus.PathComplete &&
            this.GetComponent<moveRandomly>().nav.remainingDistance == 0 &&
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
        if (other.name == "muere")
        {
            Debug.Log("te vas a morir prro!!");
            Destroy(other.gameObject);
        }
        //Destroy(this.gameObject);
        // Debug.Log("entro el objeto: "+this.name);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ENTRO A ESTA : " + collision.gameObject.name);
        switch (collision.gameObject.tag)
        {
            case "manzana":
                Debug.Log("ENTRO A ESTA : " + collision.gameObject.name);
                Destroy(collision.gameObject);
                break;
            case "muere":
                Debug.Log("ENTRO A ESTA : " + collision.gameObject.name);
                Destroy(collision.gameObject);
                break;
            case "muerte":
                Debug.Log("ENTRO A ESTA : " + collision.gameObject.name);
                Destroy(collision.gameObject);
                Destroy(GameObject.Find("Canvas"));
                SceneManager.LoadScene("Dead");
                break;
        }

        //  Debug.Log("ENTRO A ESTA : "+this.name);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Debug.Log("ENTRO A ESTA : " + collision.gameObject.name);
        switch (hit.gameObject.tag)
        {
            //case "manzana":
            //    Debug.Log("ENTRO A ESTA : " + hit.gameObject.name);
            //    Destroy(hit.gameObject);
            //    //vida = vida + 60;
            //    break;
            case "muere":
                Debug.Log("ENTRO A ESTA : " + hit.gameObject.name);
                Destroy(hit.gameObject);
                break;
            case "muerte":
                Debug.Log("ENTRO A ESTA : " + hit.gameObject.name);

                Destroy(hit.gameObject);
                Destroy(GameObject.Find("Canvas"));
                SceneManager.LoadScene(2);
                break;
        }
    }

}
