using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveLocation : MonoBehaviour
{
    [SerializeField] private yourLocation yourLocation;
    [SerializeField] private GameObject[] locate;
    [SerializeField] private GameObject[] allow;

    private int location;
    private void GetLocation()//他のクラスから変数を取得する関数
    {
        location = yourLocation.Location;
    }
    public void OnUnderButtonClick()
    {
        GetLocation();
        if(location == 0)
        {
            locate[0].gameObject.SetActive(false);
            locate[1].gameObject.SetActive(true);
            locate[2].gameObject.SetActive(false);
            allow[1].gameObject.SetActive(true);
        }
        if(location == 1)
        {
            locate[0].gameObject.SetActive(true);
            locate[1].gameObject.SetActive(false);
            locate[2].gameObject.SetActive(false);
            allow[1].gameObject.SetActive(false);
        }
        if(location == 2)
        {
            locate[0].gameObject.SetActive(false);
            locate[1].gameObject.SetActive(true);
            locate[2].gameObject.SetActive(false);
            allow[1].gameObject.SetActive(true);
        }
    }
    public void OnUpperButtonClick()
    {
        GetLocation();
        if(location == 1)
        {
            locate[0].gameObject.SetActive(false);
            locate[1].gameObject.SetActive(false);
            locate[2].gameObject.SetActive(true);
            allow[1].gameObject.SetActive(false);
        }
    }
}
