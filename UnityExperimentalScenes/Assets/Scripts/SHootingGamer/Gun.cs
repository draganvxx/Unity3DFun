using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Gun : MonoBehaviour
{
    public GameObject myBullet;
    public bool isGunAuto = false;
    private bool lockGun = false;

    private IEnumerator automaticShooting;
    // Start is called before the first frame update
    private void Start()
    {
        automaticShooting = AutoShoot();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGunAuto) { RegularShooting(); }
        if (isGunAuto) { AutoShooting(); }
    }

    void RegularShooting()
    {
        if (Input.GetAxis("Fire1") > 0f)
        {
            if (!lockGun) {
                RespawnBulletAndAddForce();
                lockGun = true;
            }
            
        }
        else
        {
            lockGun = false;
        }
    }

    void AutoShooting()
    {
        if (Input.GetAxis("Fire1") > 0f)
        {
            if (!lockGun)
            {
                StartCoroutine(automaticShooting);
                lockGun = true;
            }
        }
        else
        {
            lockGun = false;
            StopAllCoroutines();
        }
    }

    IEnumerator AutoShoot()
    {
        while (true)
        {
            RespawnBulletAndAddForce();
            yield return new WaitForSeconds(0.1f);
        }
    }

    void RespawnBulletAndAddForce()
    {
        GameObject newestBullet = Instantiate(myBullet, transform.position, transform.rotation);
        //Debug.Log(transform.position);
        newestBullet.GetComponent<Rigidbody>().AddForce(newestBullet.transform.up * 2000f);
    }
}
