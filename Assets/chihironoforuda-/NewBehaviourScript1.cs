using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{ public Sprite closedDoorSprite;
    public Sprite openedDoorSprite;

    private bool isDoorOpen = false;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // 最初は閉まっている画像を表示
        spriteRenderer.sprite = closedDoorSprite;
    }

    void Update()
    {
        // マウスがクリックされたら扉の状態を切り替える
        if (Input.GetMouseButtonDown(0))
        {
            ToggleDoor();
        }
    }

    void ToggleDoor()
    {
        // 扉の状態を反転させる
        isDoorOpen = !isDoorOpen;

        // 適切な画像を表示する
        if (isDoorOpen)
        {
            spriteRenderer.sprite = openedDoorSprite;
        }
        else
        {
            spriteRenderer.sprite = closedDoorSprite;
        }
    }
}