using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace UnityDefaultSetup
{
    public class UnityDefaultSetup_Editor
    {
        [MenuItem("Tools/Unity Default Setup/Create Default Directories")]
        public static void CreateDefaulDirectories()
        {
            CreateDirectories("_Project", "Scripts", "Scenes", "Art", "Materials", "Textures");
            Refresh();
        }

        public static void CreateDirectories(string root, params string[] directories)
        {
            string fullPath = Combine(dataPath, root);
            foreach(string newDirectory in directories)
                CreateDirectory(Combine(fullPath, newDirectory));
        }
}
}
