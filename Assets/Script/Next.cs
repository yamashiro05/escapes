using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public int ich;

    void OnMouseEnter() {
        // Aを上げる＝透明度を下げる
        this.GetComponent<SpriteRenderer>().color += new Color(0,0,0,120);
    }

    void OnMouseExit() {
        // Aを下げる＝透明度を上げる
        this.GetComponent<SpriteRenderer>().color += new Color(0,0,0,-120);
    }

    void OnMouseDown() {
        switch (ich) {
            case 1:
                SceneManager.LoadScene("Sample1");
                break;
            case 2:
                SceneManager.LoadScene("Sample2");
                break;
            case 3:
                SceneManager.LoadScene("SampleScene");
                break;
        }
    }
}
