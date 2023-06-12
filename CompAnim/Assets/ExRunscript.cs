using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExRunscript : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        print(transform.position);
        animator.SetBool("IsRunning", true);
        // this is the object position on which script is attached.
        //transform.position = new Vector3(0, 0, 0);// now we are assigning it position (0,0,0)

    }

    // Update is called once per frame
    void Update()
    {
        /*
                if(Input.GetKey(KeyCode.Space))// on pressing space key your object will move towards left
                 {

                    transform.Translate(-Vector3.right * 2.0f * Time.deltaTime);

                }
                if (transform.position.x <= -2) //checking if object reached -2 in x direction
                {
                    print("Reached position");
                }

            }*/

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize();
        if (transform.position.z < 8)
        {
            transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
            
        }


        if (transform.position.z >= 8)
        {
            //print("reached");
            animator.SetBool("IsRunning", false);
        }


    }
}