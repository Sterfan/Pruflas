using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeattackboss : MonoBehaviour
{
    public Transform[] points;
    public float speed = 5f;
    Transform currentPoint;
    int currentPointIndex;



    void Start()
    {
        currentPointIndex = 0;
        currentPoint = points[currentPointIndex];
    }


    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (Vector3.Distance (transform.position,currentPoint.position) < .1f)
        {
            if (currentPointIndex +1 < points.Length)
            {
                currentPointIndex++;
            }
            else
            {
                currentPointIndex = 0;
            }
            currentPoint = points[currentPointIndex];
        }
        Vector3 pointdirection = currentPoint.position - transform.position;
        float angle = Mathf.Atan2(pointdirection.y, pointdirection.x) * Mathf.Rad2Deg - 180f;

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);
    }
}
