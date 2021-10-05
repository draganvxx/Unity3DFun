using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AttachWeapon : MonoBehaviour
{
    public Transform attachedPos;
    public GameObject plane;
    public GameObject hammer;
    public bool isAttached;

    float x_dim;
    float z_dim;

    [SerializeField]
    GameObject sphere;

    private Vector3 initPos, initScale;
    private Quaternion initRot;
    private Transform hammerTrans;
    private Transform sphereTrans;


    void Start()
    {
        initPos = transform.position;
        initScale = transform.localScale;
        initRot = transform.rotation;
        hammerTrans = hammer.GetComponent<Transform>();
        sphereTrans = sphere.GetComponent<Transform>();

        x_dim = plane.GetComponent<MeshFilter>().mesh.bounds.size.x;
        z_dim = plane.GetComponent<MeshFilter>().mesh.bounds.size.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttached)
        {
            transform.position = attachedPos.position;
            transform.rotation = attachedPos.rotation;
            transform.localScale = transform.localScale;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isAttached)
        {
            Vector3 spawn = RandomSpawn();
            sphere.GetComponent<Renderer>().enabled = true;
            sphere.GetComponent<SphereCollider>().enabled = true;

            hammerTrans.position = spawn;
            hammerTrans.rotation = initRot;
            sphereTrans.position = spawn;

            isAttached = false;
        }
    }

    private Vector3 RandomSpawn()
    {
        Vector3 randomPos = Vector3.zero;
        randomPos.x = Random.Range(-x_dim / 2f, x_dim / 2f);
        randomPos.y = 1.3f;
        randomPos.z = Random.Range(-z_dim / 2f, z_dim / 2f);
        return randomPos;
    }
}
