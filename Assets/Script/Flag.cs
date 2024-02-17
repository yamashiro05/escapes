using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public static bool kawa = false;
    public static bool beef = false;
    public static bool vegeta = false;
    public static bool huraipan = false;
    public static bool kokku = false;
    public static bool hondana = false;
    public static bool houcho = false;
    public static bool kasanari = true;
    public static bool tane = false;
    public static bool nama = false;
    public static bool kagi = false;

    private void Start()
    {
        // 各変数の値をログに表示
        Debug.Log("kawa: " + kawa);
        Debug.Log("beef: " + beef);
        Debug.Log("vegeta: " + vegeta);
        Debug.Log("huraipan: " + huraipan);
        Debug.Log("kokku: " + kokku);
        Debug.Log("hondana: " + hondana);
        Debug.Log("houcho: " + houcho);
        Debug.Log("kasanari: " + kasanari);
        Debug.Log("tane: " + tane);
        Debug.Log("nama: " + nama);
        Debug.Log("kagi: " + kagi);
    }
    
}
