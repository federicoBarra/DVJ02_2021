using UnityEditor;

namespace DVJ02.Semana11
{
    public class ScriptableObjectCreator : Editor
    {
        private const string Path = "Assets/Clases/Clase 12";

        [MenuItem("DVJ02/Crear Scriptable Object")]
        private static void CreateScriptableObjectExample()
        {
            ScriptableObjectExample asset = CreateInstance<ScriptableObjectExample>();
            asset.name = "New SO " + asset.GetInstanceID();
            asset.name = asset.name.Replace("-", "");
            AssetDatabase.CreateAsset(asset, Path + "/" + asset.name + ".asset");

            AssetDatabase.SaveAssets();
            EditorUtility.SetDirty(asset);

        }
    }
}
