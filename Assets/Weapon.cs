using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject BulletPrefab;
    public float offset;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        //All Shooting stuff
        Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
    }
}
