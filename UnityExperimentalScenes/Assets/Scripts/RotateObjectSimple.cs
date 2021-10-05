using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectSimple : MonoBehaviour
{

    public GameObject Hammer;

    // Update is called once per frame
    void Update()
    {
        Hammer.transform.Rotate(0, 0.05f, 0);

    }
}
