using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnMouseDown()
    {
        if (Flag.kagi)
        {
            Flag.tane = false;
            Flag.nama = false;
            Flag.kagi = false;
            Flag.kasanari = true;;
            StartCoroutine(LoadEndScene());
        }
    }

    IEnumerator LoadEndScene()
    {
        // 現在のシーンのビルドインデックスを取得する
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 現在のシーン以外のシーンをアンロードする
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.buildIndex != currentSceneIndex)
            {
                SceneManager.UnloadSceneAsync(scene);
            }
        }

        // アンロードが完了するのを待つ
        while (SceneManager.sceneCount > 1)
        {
            yield return null;
        }

        // 新しいシーンをロードする
        SceneManager.LoadScene("End");
    }
}
