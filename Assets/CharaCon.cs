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
        if (Input.GetKey(KeyCode.W))
        {
            Animator.SetBool("IsWalking", true);
        }
        else if (Animator.GetBool("IsWalking"))
        {
            Animator.SetBool("IsWalking", false);
        }
    }
    public void Walk()
    { 
        transform.position += WalkSpeed * Time.deltaTime;
    }
}
