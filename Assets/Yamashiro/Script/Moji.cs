using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moji : MonoBehaviour
{
    public char get_moji;
    public static char moji1;
    public static char moji2;
    public static char moji3;
    public static char moji4;
    public int me;
    public TextMeshProUGUI text;
    // 抽出する文字の配列
    private char[] characters = { 'ジ', 'ロ', 'リ', 'キ', 'フ', 'ア', 'ク', 'ー', 'ヒ', 'ヲ', 'シ', 'ャ', 'オ', 'ズ', 'ラ', 'サ', 'ン' };
    // 現在のインデックスを追跡するための変数
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Staticの値をTextに代入
        switch (me)
        {
            case 1:
                this.GetComponent<TextMeshProUGUI>().text = moji1.ToString();
                break;
            case 2:
                this.GetComponent<TextMeshProUGUI>().text = moji2.ToString();
                break;
            case 3:
                this.GetComponent<TextMeshProUGUI>().text = moji3.ToString();
                break;
            case 4:
                this.GetComponent<TextMeshProUGUI>().text = moji4.ToString();
                break;
        }
        this.gameObject.SetActive(false);
    }

    public void clk()
    {
        // 配列から文字を取得
        get_moji = characters[currentIndex];
        // インデックスを更新して、配列が末尾に達した場合は最初に戻る
        currentIndex++;
        if (currentIndex >= characters.Length)
        {
            currentIndex = 0;
        }
        this.GetComponent<TextMeshProUGUI>().text = get_moji.ToString();

    　　//Staticの値に現在の値を代入
        switch (me)
        {
            case 1:
                moji1 = get_moji;
                break;
            case 2:
                moji2 = get_moji;
                break;
            case 3:
                moji3 = get_moji;
                break;
            case 4:
                moji4 = get_moji;
                break;
        }

    　　//正解
        if(moji1 == 'シ' && moji2 == 'ャ' && moji3 == 'オ' && moji4 == 'ズ')
        {
            text.text = "餃子の皮をゲットした";
        }

    }
}
