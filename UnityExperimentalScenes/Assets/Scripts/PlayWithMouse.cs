using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WarmUp))]
public class PlayWithMouse : MonoBehaviour
{


    public WarmUp warmUpShape;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 6.0f * 10f * Time.deltaTime, 0);
      
        if (Input.GetMouseButtonDown(0))
        {
            warmUpShape.start = true;
            warmUpShape.backToOriginalPos = false;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            warmUpShape.start = false;
            warmUpShape.backToOriginalPos = true;
        }
    }

    private void OnMouseOver()
    {
        
    }
}
