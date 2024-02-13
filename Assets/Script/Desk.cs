using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    public GameObject botan1;
    public GameObject botan2;
    public GameObject botan3;
    public GameObject batu;

    void OnMouseDown() {
        botan1.SetActive(true);
        botan2.SetActive(true);
        botan3.SetActive(true);
        batu.SetActive(true);
    }

}
