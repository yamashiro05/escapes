using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chouri : MonoBehaviour
{
    public GameObject aitem1;
    public GameObject aitem2;
    public GameObject aitem3;
    public TextMeshProUGUI text;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        aitem1.gameObject.SetActive(false);
        aitem2.gameObject.SetActive(false);
        aitem3.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        if (count == 2 && Flag.nama && Flag.huraipan && Flag.kokku) {
            aitem2.gameObject.SetActive(false);
            Flag.huraipan = false;
            Flag.kokku = false;
            aitem3.gameObject.SetActive(true);
            text.text = "餃子を作った！！";
            // 3秒後にテキストを消す
            Invoke("ResetText", 3f);
        }

        if (count == 1 && Flag.tane && Flag.kawa) {
            count++;
            Flag.nama = true;
            aitem1.gameObject.SetActive(false);
            Flag.kawa = false;
            aitem2.gameObject.SetActive(true);
            text.text = "餃子を包んだ！！";
            // 3秒後にテキストを消す
            Invoke("ResetText", 3f);
        }
        if (count == 0 && Flag.beef && Flag.vegeta && Flag.houcho) {
            count++;
            Flag.tane = true;
            Flag.beef = false;
            Flag.vegeta = false;
            Flag.houcho = false;
            aitem1.gameObject.SetActive(true);
            text.text = "餃子のたねをゲットした！！";
            // 3秒後にテキストを消す
            Invoke("ResetText", 3f);
        }

    }

    private void ResetText()
    {
        text.text = "";
    }
}
