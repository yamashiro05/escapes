using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Kazu : MonoBehaviour
{
    public int get_number;
    public static int hako_l;
    public static int hako_m;
    public static int hako_r;
    public int me;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneUnloaded += ResetStaticVariables;

    　　//Staticの値をTextに代入
        switch (me)
        {
            case 1:
                this.GetComponent<TextMeshProUGUI>().text = hako_l.ToString();
                break;
            case 2:
                this.GetComponent<TextMeshProUGUI>().text = hako_m.ToString();
                break;
            case 3:
                this.GetComponent<TextMeshProUGUI>().text = hako_r.ToString();
                break;
        }
        this.gameObject.SetActive(false);
    }

    public void clk()
    {
    　　//数字を増やし、10になったら0に戻す
        get_number = int.Parse(this.GetComponent<TextMeshProUGUI>().text) + 1;
        if(get_number >= 10)
        {
            get_number += -10;
        }
        this.GetComponent<TextMeshProUGUI>().text = get_number.ToString();

    　　//Staticの値に現在の値を代入
        switch (me)
        {
            case 1:
                hako_l = get_number;
                break;
            case 2:
                hako_m = get_number;
                break;
            case 3:
                hako_r = get_number;
                break;
        }

    　　//正解
        if(hako_l == 3 && hako_m == 3 && hako_r == 4)
        {
            text.text = "野菜を手に入れた";
            Flag.vegeta = true;
            // 3秒後にテキストを消す
            Invoke("ResetText", 3f);
        }

    }

    private void ResetText()
    {
        text.text = "";
    }

    private void ResetStaticVariables(Scene scene)
    {
        // シーンがアンロードされたときに静的な変数をリセットする
        hako_l = 0;
        hako_m = 0;
        hako_r = 0;
    }
}
