using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
     public abstract void Fire();
   
    
  
}
