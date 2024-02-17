using UnityEngine;
using UnityEngine.SceneManagement;

public class Startback : MonoBehaviour
{
    // ボタンが押されたときに呼び出される関数
    public void ButtonClick()
    {
        // "Start"という名前のシーンをロードする
        SceneManager.LoadScene("Start");
    }
}
