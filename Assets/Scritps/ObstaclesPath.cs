using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesPath : MonoBehaviour
{
    [SerializeField] private float f_MovementSpeed;

    [SerializeField] private Transform[] movePoints;

    [SerializeField] private float f_DistanceMin;

    private int i_NextStep;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoints[i_NextStep].position, f_MovementSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoints[i_NextStep].position) < f_DistanceMin)
        {
            i_NextStep += 1;
            if (i_NextStep >= movePoints.Length)
            {
                i_NextStep = 0;
            }
        }
    }
}
