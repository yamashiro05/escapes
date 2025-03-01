using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backpack : MonoBehaviour
{
    [SerializeField] GameObject backpack;
    [SerializeField] GameObject bagback;
    private bool bagOpen = false;

    public void OnButtonClick()
    {
        if(!bagback.activeSelf)
        {
            bagback.SetActive(true);
            bagOpen = true;
        }
        else
        {
            bagback.SetActive(false);
            bagOpen = false;
        }
    }
}
