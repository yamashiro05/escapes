using UnityEditor;
using UnityEngine;

public class AssetReimportChecker : AssetPostprocessor
{
    // アセットがインポートされた後に呼び出されるメソッド
    private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (string assetPath in importedAssets)
        {
            if (assetPath == "Assets/Font/Noto_Serif_JP/NotoSerifJP-Regular.otf")
            {
                // アセットが再インポートされる際の処理をここに記述する
                Debug.Log("NotoSerifJP-Regular.otfが再インポートされました。");
                // 再インポートコードをここに配置する
            }
        }
    }
}
