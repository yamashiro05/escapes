using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// 座標を定義しているクラス、オブジェクトにアタッチする
public class Waypoint : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector2[] points;
    public Vector2[] Points => points;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


+    private void OnDrawGizmos()

+    {

+        for (int i = 0; i < points.Length; i++)

+        {

+            if (i < points.Length - 1)

+            {

+                Gizmos.color = Color.yellow;

+                // 隣接する２点間の距離を引く

+                Gizmos.DrawLine(points[i], points[i + 1]);

+            }

+        }

+    }

}


