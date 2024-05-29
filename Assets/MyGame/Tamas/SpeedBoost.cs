using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    GameManager gM;
    Vector3 normalizedVelocity;
    public int speedForce;
    BoxCollider speedArea; 

    void Awake()
    {
        normalizedVelocity = gM.sceneBall.GetComponent<Rigidbody>().velocity.normalized; 
    }

    void Start()
    {
        this.gameObject.AddComponent<BoxCollider>();
        speedArea = this.gameObject.GetComponent<BoxCollider>();
        speedArea.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        gM.sceneBall.GetComponent<Rigidbody>().AddForce(normalizedVelocity * speedForce);
        Debug.Log("BOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOST");
    }
}
