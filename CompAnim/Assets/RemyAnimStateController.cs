using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyAlexaAnimStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize();

        if (transform.position.z > 8)
        {
            transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
            animator.SetBool("IsWalking", true);
        }

        if (transform.position.z <= 8)
        {
            //print("reached");
            animator.SetBool("IsWalking", false);
        }
    }
}
