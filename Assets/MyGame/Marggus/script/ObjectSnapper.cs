using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSnapper : MonoBehaviour
{
    private const float snapAngle = 45f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SnapObjectToNearestAngle();
        }
    }

    private void SnapObjectToNearestAngle()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        float nearestAngle = Mathf.Round(currentRotation.y / snapAngle) * snapAngle;
        transform.rotation = Quaternion.Euler(currentRotation.x, nearestAngle, currentRotation.z);
    }
}
