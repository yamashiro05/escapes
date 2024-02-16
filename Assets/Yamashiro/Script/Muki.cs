using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Muki : MonoBehaviour
{
    public int get_kakudo;
    public static int kakudo1;
    public static int kakudo2;
    public static int kakudo3;
    public static int kakudo4;
    public int me;
    public TextMeshProUGUI text;
    // クリックごとの回転角度
    private int[] rotationAngles = { 0, -90, -180, -270 };
    // 現在の回転インデックス
    private int currentRotationIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Staticの値をTextに代入
        switch (me)
        {
            case 1:
                transform.rotation = Quaternion.Euler(0, 0, kakudo1);
                break;
            case 2:
                transform.rotation = Quaternion.Euler(0, 0, kakudo2);
                break;
            case 3:
                transform.rotation = Quaternion.Euler(0, 0, kakudo3);
                break;
            case 4:
                transform.rotation = Quaternion.Euler(0, 0, kakudo4);
                break;
        }
        this.gameObject.SetActive(false);
    }

    public void clk()
    {
        // 次の回転角度のインデックスを更新
        currentRotationIndex = (currentRotationIndex + 1) % rotationAngles.Length;
        // 配列から角度を取得
        get_kakudo = rotationAngles[currentRotationIndex];
        // 回転
        transform.rotation = Quaternion.Euler(0, 0, get_kakudo);

    　　//Staticの値に現在の値を代入
        switch (me)
        {
            case 1:
                kakudo1 = get_kakudo;
                break;
            case 2:
                kakudo2 = get_kakudo;
                break;
            case 3:
                kakudo3 = get_kakudo;
                break;
            case 4:
                kakudo4 = get_kakudo;
                break;
        }

    　　//正解
        if(kakudo1 == -270 && kakudo2 == 0 && kakudo3 == -180 && kakudo4 == -90)
        {
            text.text = "フライパンをゲットした";
            Flag.huraipan = true;
            // 3秒後にテキストを消す
            Invoke("ResetText", 3f);
        }

    }

    private void ResetText()
    {
        text.text = "";
    }
}
