using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockZoom : MonoBehaviour
{
    [SerializeField] private raycast raycast;
    [SerializeField] private yourLocation yourLocation;
    string Obj;
    private void GetLocation()
    {
        Obj = raycast.HitObj;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
