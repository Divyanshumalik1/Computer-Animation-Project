using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyAnimationStateController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
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

    void IsLaughing(bool val)
    {
        if (val == false) { animator.SetBool("IsLaughing", false); }
        else { animator.SetBool("IsLaughing", true); }
    }

    void IsAngry(bool val)
    {
        if (val == false) { animator.SetBool("IsAngry", false); }
        else { animator.SetBool("IsAngry", true); }
    }

    void IsSad(bool val)
    {
        if (val == false) { animator.SetBool("IsSad", false); }
        else { animator.SetBool("IsSad", true); }
    }

    void IsTalking(bool val)
    {
        if (val == false) { animator.SetBool("IsTalking", false); }
        else { animator.SetBool("IsTalking", true); }
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
        IsHandShaking(false);
        IsTalking(false);
        IsLaughing(false);
        IsAngry(false);
        IsSad(false);

        if (transform.position.z < 25 )
        {
            transform.Rotate(0, 180, 0);
            animator.SetBool("IsWalking", true);
            transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
            

        }

        if (transform.position.z >= 20)
        {
            
            animator.SetBool("IsWalking", false);
            animator.SetBool("Exit", true);
        }

    }


    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.z > 15)
        {
            transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
        }

        //bool val = false;

        

        if (transform.position.z <= 15)
        {
            IsWalking(false);
            IsHandShaking(true);


            Wait();
            IsTalking(true);

            Wait();
            IsLaughing(true);

            /*Wait();
            IsSad(true);

            Wait();
            IsAngry(true);*/

            


            //IsSad(true);
            //print("remy" + transform.position);
            //print("reached");
            //animator.SetBool("IsWalking", false);
            //animator.SetBool("IsHandShaking", true);
        }

       /* void scenario(int a)
        {
            if(a == 1)
            {
                IsTalking(true);
                IsSad(true);
            }
            else if (a == 2)
            {
                IsTalking(true);
                IsSad(false);
            }

        }


        scenario(2);
        //yield return new WaitForSeconds(13.0f);
*/

    }

    
}
