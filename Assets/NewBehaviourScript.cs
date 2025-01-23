using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject projectilePrefab; // Préfab du projectile
    public Transform shootPoint; // Point de tir
    public float projectileSpeed = 10f; // Vitesse du projectile

  
  
    // Update is called once per frame
    void Update()
    {
        // Tir
        if (Input.GetButtonDown("Fire"))
        {
            Shoot();
        }
    
}
    

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = shootPoint.forward * projectileSpeed;
    }
}

}
