using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    // Start is called before the first frame update

    public float fireRate = 5;

    private float nextFireTime = 0f;

    public override void Fire()
    {
        if (Time.time >= nextFireTime && GameManager.instance.playerStats.ammo > 0)
        {
             var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<UnityEngine.Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;// Fire the pistol
            nextFireTime = Time.time + 1f / fireRate;
            GameManager.instance.playerStats.ammo--;
        }
        
            // Code to fire the weapon goes here
        
    }
    
   void Update() {

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
           Fire();
        }
        
    }
}
