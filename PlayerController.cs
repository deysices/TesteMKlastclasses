using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Walk", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Walk", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("Run", false);
        }
    }
}
