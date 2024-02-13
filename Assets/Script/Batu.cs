using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batu : MonoBehaviour
{
    public GameObject botan1;
    public GameObject botan2;
    public GameObject botan3;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        this.gameObject.SetActive(false);
        botan1.SetActive(false);
        botan2.SetActive(false);
        botan3.SetActive(false);
    }
}
