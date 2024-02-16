using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] private Vector3[] points;
    public Vector3[] Points => points;

    void Start()
    {
    }

    void Update()
    {
    }

    private void OnDrawGizmos()
    {
        // null チェックを追加
        if (points != null)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {
                    Gizmos.color = Color.yellow;
                    Gizmos.DrawLine(points[i], points[i + 1]);
                }
            }
        }
    }
}



