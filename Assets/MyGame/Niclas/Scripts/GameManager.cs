using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public Vector3 ballSpawnPosition;
    private GameObject SceneBall;
    bool spacePressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
            SpawnNewBall();          
        }
        
        if (spacePressed == true && SceneBall.GetComponent<Rigidbody>().velocity.magnitude < 0.001f)
        {
            Destroy(SceneBall);
            SpawnNewBall();
        }
    }

    public void SpawnNewBall()
    {
        Debug.Log("Geht eh");
        SceneBall = Instantiate(ball, ballSpawnPosition, Quaternion.identity);
    }

    
}
