using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batu2 : MonoBehaviour
{
    public GameObject nyuryoku;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        Flag.kasanari = true;
        this.gameObject.SetActive(false);
        nyuryoku.SetActive(false);
    }
}
