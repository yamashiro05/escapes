using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Batu1 : MonoBehaviour
{
    public GameObject nyuryoku;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        this.gameObject.SetActive(false);
        nyuryoku.SetActive(false);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        if (text4 != null) {
            text4.gameObject.SetActive(false);
        }
    }
}
