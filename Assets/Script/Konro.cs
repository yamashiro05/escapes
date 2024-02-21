using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Konro : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject aitem2;
    public GameObject aitem3;

    // Start is called before the first frame update
    void Start()
    {
        aitem3.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        if (Flag.kasanari) {
            if (Manaita.count == 2 && Flag.nama && Flag.huraipan && Flag.kokku2) {
                aitem2.gameObject.SetActive(false);
                Flag.huraipan = false;
                //Flag.kokku = false;
                aitem3.gameObject.SetActive(true);
                text.text = "餃子を作った！！";
                // 3秒後にテキストを消す
                Invoke("ResetText", 3f);
            }

            if (!Flag.kokku2) {
                text.text = "火がつかない...";
                // 3秒後にテキストを消す
                Invoke("ResetText", 3f);
            }
        }
    }
}
