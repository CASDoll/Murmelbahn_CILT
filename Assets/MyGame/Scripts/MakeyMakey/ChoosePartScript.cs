using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePartScript : MonoBehaviour
{
    public GameObject buildingPart1;
    public GameObject buildingPart2;
    public GameObject buildingPart3;
    public GameObject buildingPart4;
    
    int currentPart = 0;
    int currentSpecialAbility = 0;
    string currentPartTag = "buildingPart0";


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && currentPart != 1)
        {
            Instantiate(buildingPart1);
            currentPart = 1;
            DestroyArray();
            currentPartTag = "buildingPart1";
            Debug.Log("Part 1 runthrough");
        }

        if (Input.GetKey(KeyCode.RightArrow) && currentPart != 2)
        {
            Instantiate(buildingPart2);
            currentPart = 2;
            DestroyArray(); ;
            currentPartTag = "buildingPart2";
        }

        if (Input.GetKey(KeyCode.UpArrow) && currentPart != 3)
        {
            Instantiate(buildingPart3);
            currentPart = 3;
            DestroyArray();
            currentPartTag = "buildingPart3";
        }

        if (Input.GetKey(KeyCode.DownArrow) && currentPart != 4)
        {
            Instantiate(buildingPart4);
            currentPart = 4;
            DestroyArray();
            currentPartTag = "buildingPart4";
        }

        if (Input.GetMouseButton(1) && currentSpecialAbility != 1)
        {
            ToggleSpecialAbility(-1);
        }
        
        if (Input.GetKey(KeyCode.Space) && currentSpecialAbility != 2)
        {
            ToggleSpecialAbility(1);
        }
    }

    void ToggleSpecialAbility(int current)
    {
        GameObject currentGameObject;
        currentGameObject = GameObject.FindGameObjectWithTag(currentPartTag);
      /*if (-1 <= currentGameObject.GetComponent("ChangeSpeedScript").speedChange + current <= 1)
        {
            currentGameObject.GetComponent("ChangeSpeedScript").speedChange = currentGameObject.GetComponent("ChangeSpeedScript").speedChange + current;
        }*/
    }

    void DestroyArray()
    {
        if (currentPartTag != "buildingPart0")
        {            
            Destroy(GameObject.FindGameObjectWithTag(currentPartTag));
        }
    }
}
