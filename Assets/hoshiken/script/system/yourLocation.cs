using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yourLocation : MonoBehaviour
{
    [SerializeField] private GameObject[] room;
    private int location;
    public int Location => location;//他のクラスでも使えるようにする文

    void Start()
    {
        UpdateLocation();
    }

    void Update()
    {
        UpdateLocation();
    }

    private void UpdateLocation()
    {
        if (room == null || room.Length == 0) return; // null チェック

        for (int i = 0; i <= room.Length; i++) // `i = 0` から開始
        {
            if (room[i].activeSelf)
            {
                location = i;
                //Debug.Log(location);
                return; // 最初に見つかったアクティブな部屋で処理を終了
            }
        }
    }
}
