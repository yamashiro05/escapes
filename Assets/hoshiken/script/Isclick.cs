using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isclick : MonoBehaviour
{
    void Update()
    {
        // マウスクリックを判定
        if (Input.GetMouseButtonDown(0)) // 0は左クリック
        {
            // マウス位置を取得し、スクリーン座標からワールド座標に変換
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // クリック位置のオブジェクトを検出
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                // オブジェクトに対する処理
                Debug.Log($"Clicked on {hit.collider.gameObject.name}");
            }
        }
    }
}
