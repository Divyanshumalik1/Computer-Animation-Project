using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexaAnimationStateController : MonoBehaviour
{
    //public RemyAnimationStateController animatorb;

    Animator animator;
    //Animator remy;
    // Start is called before the first frame update
    void Start()
    {
        ///animatorb = GetComponent<RemyAnimationStateController>();
        //Debug.Log(animatorb.animator);
         //remy = animatorb.animator;

        animator = GetComponent<Animator>();
        animator.SetBool("IsWalking", true);
        StartCoroutine(Example());

    }

    void IsWalking(bool val)
    {
        if (val == false) { animator.SetBool("IsWalking", false); }
        else { animator.SetBool("IsWalking", true); }
    }

    void IsHandShaking(bool val)
    {
        if (val == false) { animator.SetBool("IsHandShaking", false); }
        else { animator.SetBool("IsHandShaking", true); }
    }

    void IsHappy(bool val)
    {
        if (val == false) { animator.SetBool("IsHappy", false); }
        else { animator.SetBool("IsHappy", true); }
    }

    void IsAngry(bool val)
    {
        if (val == false) { animator.SetBool("IsAngry", false); }
        else { animator.SetBool("IsAngry", true); }
    }

    void IsThrowing(bool val)
    {
        //transform.Translate(Vector3.backward * 1.0f * Time.deltaTime);
        if (val == false) { animator.SetBool("IsThrowing", false); }
        else { animator.SetBool("IsThrowing", true); }
    }

    IEnumerator Wait()
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(7);
    }

        IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(30);
        print(Time.time);
        IsWalking(true);
        IsAngry(false);
        IsHandShaking(false);
        IsHappy(false);
        IsThrowing(false);

        if (transform.position.z > 9 )
        {
            transform.Rotate(0, 180, 0);
            animator.SetBool("IsWalking", true);
            transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
            
        }

        if (transform.position.z <= 9)
        {
           
            animator.SetBool("IsWalking", false);
            animator.SetBool("Exit", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize();*/



        if (transform.position.z < 13.5)
        {
            transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
           
        }

        //bool val = false;

        
        if (transform.position.z >= 13.5)
        {
            IsWalking(false);
            IsHandShaking(true);

            Wait();
            IsHappy(true);

            /*Wait();
            IsAngry(true);

            Wait();
            IsThrowing(true);*/

            //IsHappy(false);



            //print("alexa"+transform.position);
            //print("reached");
            /*animator.SetBool("IsWalking", false);
            animator.SetBool("IsHandShaking", true);
            animator.SetBool("IsAngry", false);*/

        }

              //11.57


    }
}
