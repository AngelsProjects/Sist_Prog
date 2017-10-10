using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class controlador : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    public Animator anim;
    public int walk = Animator.StringToHash("Walk");
    public int jump = Animator.StringToHash("Jump");
    public int eat = Animator.StringToHash("Eat");
    public int idle = Animator.StringToHash("Idle");
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);


        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("Walk");
        }
        if (!Input.GetKeyDown(KeyCode.DownArrow) || !Input.GetKeyDown(KeyCode.UpArrow) || !Input.GetKeyDown(KeyCode.LeftArrow) || !Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
    }
    // Use this for initialization
    void Start()
    {
        //anim = GetComponent<Animation>();
        //anim.Play();
        anim = GetComponent<Animator>();

    }
}