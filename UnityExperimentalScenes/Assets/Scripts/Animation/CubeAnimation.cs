using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Animator))]
public class CubeAnimation : MonoBehaviour
{

    Animator anim;
    string whatAnim = "CubeSpin";
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        /*if (whatAnim == "CubeSpin") {
            whatAnim = "Move";

        }
        else
        {
            whatAnim = "CubeSpin";
        }*/

        anim.SetTrigger("Color");
        anim.SetTrigger("Zip");
    }

}
