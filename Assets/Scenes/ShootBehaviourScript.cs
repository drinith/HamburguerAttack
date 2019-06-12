using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ShootBehaviourScript : MonoBehaviour
{

    public float bulletSpeed = 100;
    [SerializeField] public Rigidbody bullet;
    private Rigidbody bulletClone;


    void Fire()
    {
        bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
		bulletClone.velocity = transform.forward * bulletSpeed;
        if (Mathf.Abs(bulletClone.position.x) >= 100 || Mathf.Abs(bulletClone.position.z) >= 100)
        {
            Destroy(bulletClone);
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
            Fire();
        
        
    }

    void OnBecameInvisible()
    {

        Destroy(gameObject);
     

    }
}

    