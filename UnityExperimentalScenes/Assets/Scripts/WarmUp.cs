using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmUp : MonoBehaviour
{
    public Vector2 rotateDirection;
    public Vector2 size;
    public bool start;
    public bool backToOriginalPos;

    private float logicTime;
    private Vector3 initialPos;


    // Start is called before the first frame update
    void Start()
    {
        initialPos = gameObject.transform.position;
        start = false;
        backToOriginalPos = false;
        logicTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (start) 
        {
            backToOriginalPos = false;
            MakeCircles(logicTime, rotateDirection, size);
        }
        else if (backToOriginalPos)
        {
            start = false;
            BackToStart();
        }
    }

    void MakeCircles(float time, Vector2 direction, Vector2 sizeOfMovement)
    {
        float x = Mathf.Sin(time * direction.x) * sizeOfMovement.x;
        float y = Mathf.Cos(time * direction.y) * sizeOfMovement.y;
        x *= (y + size.y) / (2f * size.y);
        gameObject.transform.position = initialPos + new Vector3(x, y, 0);
        logicTime += Time.deltaTime;
    }

    void BackToStart()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, initialPos, Time.deltaTime * 1);
    }

}
