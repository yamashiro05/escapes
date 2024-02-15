using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Katati : MonoBehaviour
{
    public int me;
    public TextMeshProUGUI text;
    public GameObject[] objectsArray = new GameObject[4]; // ゲームオブジェクトの配列
    public static int currentIndex1 = 0; // 現在の配列インデックス
    public static int currentIndex2 = 0;
    public static int currentIndex3 = 0;
    public static int currentIndex4 = 0;
    public GameObject currentObject; // 変数を宣言しておく

    // Start is called before the first frame update
    void Start()
    {

        // 初期状態では配列の最初のオブジェクトを表示
        switch (me)
        {
            case 1:
                currentObject = objectsArray[currentIndex1];
                break;
            case 2:
                currentObject = objectsArray[currentIndex2];
                break;
            case 3:
                currentObject = objectsArray[currentIndex3];
                break;
            case 4:
                currentObject = objectsArray[currentIndex4];
                break;

            // デバッグログを表示
            Debug.Log("これはデバッグログです");
            this.gameObject.SetActive(false);
            
        }
    }

    public void clk()
    {
        // 新しいオブジェクトを生成
        GameObject newObject = null;

        // 現在のオブジェクトを削除
        if (currentObject != null)
        {
            Destroy(currentObject);
        }

    　　//Staticの値に現在の値を代入
        switch (me)
        {
            case 1:
                // クリックされたら次のオブジェクトを表示
                currentIndex1 = (currentIndex1 + 1) % objectsArray.Length;
                // 配列の現在のインデックスに対応するオブジェクトを表示
                newObject = Instantiate(objectsArray[currentIndex1]);
                break;
            case 2:
                // クリックされたら次のオブジェクトを表示
                currentIndex2 = (currentIndex2 + 1) % objectsArray.Length;
                newObject = Instantiate(objectsArray[currentIndex2]);
                break;
            case 3:
                // クリックされたら次のオブジェクトを表示
                currentIndex3 = (currentIndex3 + 1) % objectsArray.Length;
                newObject = Instantiate(objectsArray[currentIndex3]);
                break;
            case 4:
                // クリックされたら次のオブジェクトを表示
                currentIndex4 = (currentIndex4 + 1) % objectsArray.Length;
                newObject = Instantiate(objectsArray[currentIndex4]);
                break;
        }

        /*// 現在のオブジェクトを新しいオブジェクトに更新
        currentObject = newObject;
        currentObject.transform.position = new Vector3(currentObject.transform.position.x, currentObject.transform.position.y, currentObject.transform.position.z);*/
        // 新しいオブジェクトが null でない場合のみ、currentObject を更新
        if (newObject != null)
        {
            currentObject = newObject;
            currentObject.transform.position = new Vector3(currentObject.transform.position.x, currentObject.transform.position.y, currentObject.transform.position.z);
        }

    　　//正解
        /*if(kakudo1 == -270 && kakudo2 == 0 && kakudo3 == -90 && kakudo4 == -180)
        {
            text.text = "フライパンをゲットした";
        }*/

    }

}
