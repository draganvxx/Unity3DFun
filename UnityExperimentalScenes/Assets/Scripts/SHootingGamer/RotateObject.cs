using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public GameObject Hammer;

    // Update is called once per frame
    void Update()
    {
        Hammer.transform.Rotate(0.25f, 0, 0);

    }
}
