using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CornerMover : MonoBehaviour
{
    public static GameObject blackDotPrefab; // 黒点のプレハブ
    public static GameObject currentDot; // 現在の黒点
    public int currentCornerIndex; // 現在の角のインデックス
    public static int index1;
    public static int index2;
    public static int index3;
    public static int index4;
    public TextMeshProUGUI text;
    public int me;

    // Start is called before the first frame update
    void Start()
    {
        // 例えば、Resources.Load() を使用してプレハブを読み込む
        blackDotPrefab = Resources.Load<GameObject>("kurotenn");

        // プレハブを生成して非アクティブにする
        currentDot = Instantiate(blackDotPrefab, Vector3.zero, Quaternion.identity);
        //Staticの値をTextに代入
        switch (me)
        {
            case 1:
                SpawnDot(GetCornerPosition(index1));
                break;
            case 2:
                SpawnDot(GetCornerPosition(index2));
                break;
            case 3:
                SpawnDot(GetCornerPosition(index3));
                break;
            case 4:
                SpawnDot(GetCornerPosition(index4));
                break;
        }
        this.gameObject.SetActive(false);
        currentDot.SetActive(false);
        //blackDotPrefab.SetActive(false);
    }

    public void clk()
    {
    　　// 現在の黒点を削除
        Destroy(currentDot);

        // 次の角のインデックスを更新
        currentCornerIndex++;

        // インデックスを0から3の間にループ
        currentCornerIndex %= 4;

        // 次の角に黒点を生成
        SpawnDot(GetCornerPosition(currentCornerIndex));

    　　//Staticの値に現在の値を代入
        switch (me)
        {
            case 1:
                index1 = currentCornerIndex;
                break;
            case 2:
                index2 = currentCornerIndex;
                break;
            case 3:
                index3 = currentCornerIndex;
                break;
            case 4:
                index4 = currentCornerIndex;
                break;
        }

    　　//正解
        if(index1 == 3 && index2 == 1 && index3 == 3 && index4 == 2)
        {
            text.text = "箱の中には……";
        }

    }

    Vector3 GetCornerPosition(int cornerIndex)
    {
        // 角の位置を計算
        switch (cornerIndex)
        {
            case 0: // 右上の角
                return new Vector3(transform.position.x + transform.localScale.x / 2f, transform.position.y + transform.localScale.y / 2f, transform.position.z);
            case 1: // 右下の角
                return new Vector3(transform.position.x + transform.localScale.x / 2f, transform.position.y - transform.localScale.y / 2f, transform.position.z);
            case 2: // 左下の角
                return new Vector3(transform.position.x - transform.localScale.x / 2f, transform.position.y - transform.localScale.y / 2f, transform.position.z);
            case 3: // 左上の角
                return new Vector3(transform.position.x - transform.localScale.x / 2f, transform.position.y + transform.localScale.y / 2f, transform.position.z);
            default:
                return transform.position;
        }
    }

    void SpawnDot(Vector3 position)
    {
        // 黒点を生成し、位置を設定
        currentDot = Instantiate(blackDotPrefab, position, Quaternion.identity);
    }
}
