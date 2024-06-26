using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstanzeSpawnBall : MonoBehaviour
{
    public GameObject obj;
    int randNum;
    public Transform spawnDest1, spawnDest2, spawnDest3, spawnDest4;
    public bool spawning = true;
    public Vector3 Pos1, Pos2, Pos3, Pos4;
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnNewBall();
        }
    }

    void SpawnNewBall()
    {
        randNum = Random.Range(0, 4);
        if (randNum == 0)
        {
            
            Instantiate(obj, spawnDest1.position, spawnDest1.rotation);
        }
        if (randNum == 1)
        {
            Instantiate(obj, spawnDest2.position, spawnDest2.rotation);
        }
        if (randNum == 2)
        {
            Instantiate(obj, spawnDest3.position, spawnDest3.rotation);
        }
        if (randNum == 3)
        {
            Instantiate(obj, spawnDest4.position, spawnDest4.rotation);
        }
    }
}

