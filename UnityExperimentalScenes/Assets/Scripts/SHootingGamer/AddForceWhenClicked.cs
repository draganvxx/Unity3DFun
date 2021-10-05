using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceWhenClicked : MonoBehaviour
{
    private bool control;

    private void Start()
    {
        control = false;
    }

    private void Update()
    {
        if (control == false)
        {
            OnInputLeftAlt();
        }
    }
    public void OnInputLeftAlt()
    {
        if (Input.GetAxis("Fire2") > 0)
        {
            Debug.Log("Force added with Fire2");
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 5f);
            control = true;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Force added with click");
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 5f);
    }

}
