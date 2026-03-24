using UnityEditor;

namespace ModularArchitecture.Editor 
{
    public class ScriptTemplates 
    {
        [MenuItem("Assets/Create/Modular/Scripts/Enum Script", priority = 3)]
        public static void CreateEnumScript()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/ModularArchitecture/Editor/ScriptTemplates/New Enum Script Template.txt",
                "New Enum.cs"
            );
        }
    }
}
