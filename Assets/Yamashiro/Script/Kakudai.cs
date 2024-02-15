using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kakudai : MonoBehaviour
{
    public GameObject botan1;
    public GameObject batu;

    void OnMouseDown() {
        if (Flag.kasanari) {
            botan1.SetActive(true);
            batu.SetActive(true);
        }
        Flag.kasanari = false;
    }

}
