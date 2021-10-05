using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRocks : MonoBehaviour
{
    public GameObject[] rocks;
    public MeshCollider[] rockCollider;

    void Start()
    {
        rocks = GameObject.FindGameObjectsWithTag("Rock");
        
    }
    public void OnClicked()
    {
        foreach (GameObject obj in rocks)
        {
            obj.GetComponent<MeshCollider>().enabled = true;
            obj.AddComponent<Rigidbody>();
        }


    }
}
