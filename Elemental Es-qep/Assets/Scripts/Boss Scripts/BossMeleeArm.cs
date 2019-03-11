using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMeleeArm : MonoBehaviour
{
    public GameObject detectionLine;
    
    public float moveSpeed = 10;
    public GameObject pointA;
    public GameObject pointB;
    private bool reverseMove = false;
    public Transform objectToUse;
    public bool allowedToMove = false;
    private float startTime;
    private float pathMovement;
    private float distance;
    private float path;

    void Start()
    {
        startTime = Time.deltaTime;

        pathMovement = Vector3.Distance(pointA.transform.position, pointB.transform.position);
    }

    
    void Update()
        {
        if (allowedToMove == true)
        {
            distance = (Time.time - startTime) * moveSpeed;
            path = distance / pathMovement;
            if (reverseMove)
            {
                objectToUse.position = Vector3.Lerp(pointB.transform.position, pointA.transform.position, path);
            }
            else
            {
                objectToUse.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, path);
            }
            if ((Vector3.Distance(objectToUse.position, pointB.transform.position) == 0.0f))//|| Vector3.Distance(objectToUse.position, pointA.transform.position) == 0.0f)) //Checks if the object has travelled to one of the points
            {

                reverseMove = false;

                startTime = Time.time;
            }
            else
            {
                reverseMove = true;
            }
        }
        }
}