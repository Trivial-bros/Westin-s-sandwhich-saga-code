using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public Audio_Manager audio_Manager;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        audio_Manager.Play("Shoot");
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
