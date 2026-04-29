// Dependancies :
using UnityEditor;

namespace ModularArchitecture.Editor 
{
    public class ScriptTemplates 
    {
        [MenuItem("Assets/Create/Modular/Enums/Create New Extendable Enum", priority = 0)]
        public static void CreateEnumScript()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.ryanellisdale.modular-architecture/Editor/ScriptTemplates/Enum Script Template.txt",
                "New Enum.cs"
            );
        }
    }
}
