using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kinko : MonoBehaviour
{
    public GameObject nyuryoku;
    public GameObject batu;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public GameObject aitem;
    public GameObject tobira;

    void OnMouseDown() {
        if (aitem != null && !aitem.gameObject.activeSelf) {
            if (Flag.kasanari) {
                nyuryoku.SetActive(true);
                batu.SetActive(true);
                text1.gameObject.SetActive(true);
                text2.gameObject.SetActive(true);
                text3.gameObject.SetActive(true);
                if (text4 != null) {
                    text4.gameObject.SetActive(true);
                }
            }
            Flag.kasanari = false;
        } else {
            if (Flag.kasanari) {
                if (!tobira.gameObject.activeSelf) {
                    tobira.gameObject.SetActive(true);
                    Debug.Log("開く");
                } else {
                    tobira.gameObject.SetActive(false);
                    Debug.Log("閉める");
                }
            }
        }
    }
}
