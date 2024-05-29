using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstanzeSpawnBall : MonoBehaviour
{
    public GameObject ball;
    public Vector3 ballSpawnPosition;
    private GameObject sceneBall;
    bool spacePressed;
    private float timer;

    public Transform ballSpawn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnNewBall();
        }
    }

    public void SpawnNewBall()
    {
        Debug.Log("Geht");
        sceneBall = Instantiate(ball, ballSpawnPosition, Quaternion.identity);
        sceneBall.transform.SetParent(ballSpawn);
        sceneBall.transform.position = ballSpawn.position;
    }
}
