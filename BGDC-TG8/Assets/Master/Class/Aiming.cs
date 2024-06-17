using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{

    private Camera mainCam;
    private Vector3 mousePos;

    public Transform firePoint;
    public GameObject bulletFab;

    public float bulletForce = 22f;

    public float Firerate = 1;

    private float coolFire;


    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotate = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotate.y, rotate.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,rotZ);

        if(Input.GetButtonDown("Fire1") && Time.time > coolFire)
        {
            coolFire = Time.time + Firerate;

            Instantiate(bulletFab, firePoint.position, Quaternion.identity);
        }
    }
}
