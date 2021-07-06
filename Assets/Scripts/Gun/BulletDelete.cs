using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDelete : MonoBehaviour
{
    Rigidbody bulletRb;
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        Destroy(gameObject, 18f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
