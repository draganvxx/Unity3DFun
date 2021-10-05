using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputProject : MonoBehaviour
{

    private Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * Input.GetAxis("Ice"));
        transform.position = initPos + Vector3.right* Input.GetAxis("Ice");
    }
}
