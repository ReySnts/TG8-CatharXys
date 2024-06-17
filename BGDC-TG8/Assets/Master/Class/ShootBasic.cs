using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBasic : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletFab;

    public float bulletForce = 22f;

    public float Firerate = 1;

    private float coolFire;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time > coolFire)
        {
            coolFire = Time.time + Firerate;

            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletFab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody2D = bullet.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
