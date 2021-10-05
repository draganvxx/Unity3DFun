using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatController : MonoBehaviour
{
    Animator anim;
    CharacterController swatCC;
    float ungroundedTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("Idle", true);
        anim.SetBool("Grounded", true);
        swatCC = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"));
        Debug.Log(swatCC.isGrounded);
        if (swatCC.isGrounded)
        {
            ungroundedTime = 0f;
            anim.SetBool("Grounded", true);
            if (Input.GetAxis("Vertical") > 0f)
            {
                anim.SetBool("Walk", true);
                anim.SetBool("Idle", false);
                anim.SetBool("Run", false);
            }
            else
            {
                anim.SetBool("Idle", true);
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);
            }

            if (Input.GetAxis("Vertical") > 0f && Input.GetAxis("Fire3") > 0f)
            {
                anim.SetBool("Walk", false);
                anim.SetBool("Idle", false);
                anim.SetBool("Run", true);
            }
            else if (Input.GetAxis("Vertical") > 0f)
            {
                anim.SetBool("Idle", false);
                anim.SetBool("Run", false);
                anim.SetBool("Walk", true);

            }
            else
            {
                anim.SetBool("Idle", true);
                anim.SetBool("Run", false);
                anim.SetBool("Walk", false);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                anim.SetBool("Dance", true);
                anim.SetBool("Idle", false);
            }
            else
            {
                anim.SetBool("Dance", false);
            }

            if (Input.GetAxis("Jump") > 0f)
            {
                Debug.Log("Jump");
                anim.SetBool("Jump", true);
            } 
            else
            {
                anim.SetBool("Jump", false);
            }
            Debug.Log(Input.GetAxis("Jump"));
        } else
        {
            ungroundedTime += Time.deltaTime;
            Debug.Log(ungroundedTime);
            Debug.Log(swatCC.isGrounded);
            if (ungroundedTime > 1f)
            {
                anim.SetBool("Grounded", false);
                anim.SetBool("Walk", false);
                anim.SetBool("Idle", false);
                anim.SetBool("Run", false);
                Debug.Log(swatCC.isGrounded + "after ungrounding");
            }
        }

        
    }
}
