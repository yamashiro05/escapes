using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kokkusen : MonoBehaviour
{
    public GameObject aitem1;
    public GameObject aitem2;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        aitem2.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        if (Flag.kasanari) {
            if (Flag.kokku) {
                aitem1.gameObject.SetActive(false);
                Flag.kokku = false;
                Flag.kokku2 = true;
                aitem2.gameObject.SetActive(true);
                text.text = "ガスが使えるようになった！！";
                // 3秒後にテキストを消す
                Invoke("ResetText", 3f);
            }
        }
    }
}
