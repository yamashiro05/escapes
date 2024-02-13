using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinko : MonoBehaviour
{
    public GameObject nyuryoku;
    public GameObject batu;

    void OnMouseDown() {
        nyuryoku.SetActive(true);
        batu.SetActive(true);
    }
}
