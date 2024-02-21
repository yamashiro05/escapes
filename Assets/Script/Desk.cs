using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    public GameObject botan1;
    public GameObject botan2;
    public GameObject botan3;
    public GameObject botan4;
    public GameObject batu;
    public GameObject aitem;
    public GameObject tobira;

    void Start() {
        //tobira.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        if (aitem != null && !aitem.gameObject.activeSelf) {
            if (Flag.kasanari) {
                botan1.SetActive(true);
                botan2.SetActive(true);
                botan3.SetActive(true);
                if (botan4 != null) {
                    botan4.SetActive(true);
                }
                batu.SetActive(true);
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
