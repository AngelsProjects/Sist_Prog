using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moveRandomly : MonoBehaviour
{
    public NavMeshAgent nav;
    public float timer;
    bool inCoRoutine;
    public Vector3 target;
    NavMeshPath path;
    bool validPath;
    // Use this for initialization
    void Start()
    {
        Debug.Log("inicio ESTA MADRE: " + this.name);
        nav = gameObject.GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        getNewPath();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inCoRoutine)
        {
            StartCoroutine(DoSomething());
        }
    }
    Vector3 newPosition()
    {
        float x = Random.Range(-40, 38);
        float z = Random.Range(-35, 35);
        Vector3 pos = new Vector3(x, 0, z);
        return pos;
    }
    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timer);
        getNewPath();
        validPath = nav.CalculatePath(target, path);
        if (!validPath)
        {
            Debug.Log("found an invalid path");
        }
        while (!validPath)
        {
            yield return new WaitForSeconds(0.01f);
            getNewPath();
            validPath = nav.CalculatePath(target, path);
        }
        inCoRoutine = false;
    }
    void getNewPath()
    {
        target = newPosition();
        nav.SetDestination(target);
    }
}
