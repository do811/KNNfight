using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CharaCon : MonoBehaviour
{
    public Animator Animator;
    protected Vector3 WalkSpeed = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Animator.SetBool("IsWalking", true);
        }
        else if (Animator.GetBool("IsWalking"))
        {
            Animator.SetBool("IsWalking", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Animator.SetBool("IsBack", true);
        }
        else if (Animator.GetBool("IsBack"))
        {
            Animator.SetBool("IsBack", false);
        }

        if (Input.GetKey(KeyCode.U))
        {
            Animator.SetBool("IsPunchLow", true);
        }
        else if (Animator.GetBool("IsPunchLow"))
        {
            Animator.SetBool("IsPunchLow", false);
        }
        
    }

    public void Walk()
    {
        transform.position += WalkSpeed * Time.deltaTime;
    }

    public void Back()
    {
        transform.position -= WalkSpeed * Time.deltaTime;
    }
}
