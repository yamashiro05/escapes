using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    private string hitObj;
    public string HitObj => hitObj;//hitObjを他のクラスでも使えるようにHitObjと置いてpublicにする。

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリック
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Hit: " + hit.collider.gameObject.name);
                hitObj = hit.collider.gameObject.name;
            }
        }
    }
}
