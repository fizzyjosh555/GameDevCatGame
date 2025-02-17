﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject platform;
    public float SpeedPlatform;
    private Transform currentPoint;
    public Transform[] points;
    public int pointSelection;

    void Start()
    {
        currentPoint = points[pointSelection];
    }

    void FixedUpdate()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, currentPoint.position, Time.deltaTime * SpeedPlatform);
        if (platform.transform.position == currentPoint.position)
        {
            pointSelection++;

            if(pointSelection == points.Length)
            {
                pointSelection = 0;
            }
            currentPoint = points[pointSelection];
        }
    }
}
