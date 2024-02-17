using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kagi : MonoBehaviour
{
    public GameObject gyouza;
    public TextMeshProUGUI text;

    void OnMouseDown() {
        gyouza.gameObject.SetActive(false);
        Flag.kagi = true;
        text.text = "鍵をゲットした！！";
        // 3秒後にテキストを消す
        Invoke("ResetText", 2f);
    }

    private void ResetText()
    {
        text.text = "";
    }
}
