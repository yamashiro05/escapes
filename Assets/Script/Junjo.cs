using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Junjo : MonoBehaviour
{
    private static int[] sequence = {2,2,0,1,2}; // 正解順序
    private static int currentIndex = 0;

    public int buttonIndex; // ボタンのインデックス

    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    /*void OnMouseEnter() {
        // Aを上げる＝透明度を下げる
        this.GetComponent<SpriteRenderer>().color += new Color(0,0,0,-50);
    }

    void OnMouseExit() {
        // Aを下げる＝透明度を上げる
        this.GetComponent<SpriteRenderer>().color += new Color(0,0,0,+50);
    }*/

    private void OnMouseDown()
    {
        // 透明度を下げる
        Color modifiedColor = originalColor;
        modifiedColor.a -= 0.5f; // 透明度を半分に下げる（0.5は適当な値です。必要に応じて調整してください）
        spriteRenderer.color = modifiedColor;

        // 0.5秒後に透明度を元に戻す
        Invoke("RestoreColor", 0.2f);

        if (buttonIndex == sequence[currentIndex])
        {
            currentIndex++;
            if (currentIndex == sequence.Length)
            {
                Debug.Log("正解");
                text.text = "包丁をゲットした";
                currentIndex = 0; // シーケンスのリセット
            }
        }
        else
        {
            // 不正解の場合はリセット
            currentIndex = 0;
        }
    }

    private void RestoreColor()
    {
        spriteRenderer.color = originalColor;
    }
}
