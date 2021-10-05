using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetSnap : MonoBehaviour
{
    public AttachWeapon attach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.parent.Rotate(Vector3.up, 20f*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        attach.isAttached = true;
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<SphereCollider>().enabled = false;
    }
}
