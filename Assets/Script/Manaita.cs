using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manaita : MonoBehaviour
{
    public GameObject aitem1;
    public GameObject aitem2;
    public static int count = 0;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        aitem1.gameObject.SetActive(false);
        aitem2.gameObject.SetActive(false);
    }

    void OnMouseDown() {
        if (Flag.kasanari) {

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
    }
}
