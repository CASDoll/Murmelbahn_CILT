using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{

    public float velCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (GetComponent<Rigidbody>().velocity.magnitude <= 0.000001f && transform.position.y < -2f);
        {
            Destroy(gameObject);
        }
        */
        velCheck = GetComponent<Rigidbody>().velocity.magnitude;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
