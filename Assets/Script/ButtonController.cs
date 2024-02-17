using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // ボタンが押されたときに呼び出される関数
    public void OnButtonClick()
    {
        // "Iriguti"という名前のシーンをロードする
        SceneManager.LoadScene("Iriguti");
    }
}
