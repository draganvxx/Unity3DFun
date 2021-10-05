using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDo : MonoBehaviour
{
    private void OnMouseDown()
    {
        /*if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("middle mouse);
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }*/
        Debug.Log(gameObject.name);
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(2))
        {
            Debug.Log(gameObject.name);
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }*/
    }
}
