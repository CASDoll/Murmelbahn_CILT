using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeedScript : MonoBehaviour
{
    public float speedChange = 1f;
    public Rigidbody marbleRigidbody;
    Vector3 currentVelocity;

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        currentVelocity = marbleRigidbody.velocity;
    }

    private void OnTriggerStay(Collider other)
    {
        marbleRigidbody.AddForce(currentVelocity*speedChange, ForceMode.VelocityChange);
    }
}
