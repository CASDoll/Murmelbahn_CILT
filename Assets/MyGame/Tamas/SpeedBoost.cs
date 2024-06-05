using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameManager gM;
    Vector3 normalizedVelocity;
    public int speedForce;

    void Awake()
    {
        
    }

    void Start()
    {

    }

    private void Update()
    {
        normalizedVelocity = gM.sceneBall.GetComponent<Rigidbody>().velocity.normalized;
        //Debug.Log(normalizedVelocity);
    }

    private void OnTriggerEnter(Collider other)
    {
        gM.sceneBall.GetComponent<Rigidbody>().AddForce(normalizedVelocity * Time.deltaTime * speedForce);
        Debug.Log("BOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOST");
    }
}
