// Edits the runtime example script provided in the Runtime/ folder. 
// Adds a button to the mono behaviour's inspector window that prints the script's example string.
// Editor scripts are put in there own sub-namespace as to seperate them from runtime logic

#if UNITY_EDITOR
// Dependancies :
using UnityEditor;
using UnityEngine;
using PackageTemplate;

namespace PackageTemplate.Editor // Root Namespace declared in Assembly Definition
{
    [CustomEditor(typeof(RuntimeExample))]
    public class EditorExample : UnityEditor.Editor
    {
        // Adds button to Runtime Example Mono Behaviour script
        // Button will print the target's example variable. 
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            // Runtime Script : 
            RuntimeExample subject = (RuntimeExample)target;

            // Button :
            if (GUILayout.Button("Print Example Message"))
            {
                Debug.Log(subject.example);
            }
        }
    }
}
#endif

// Ryan Ellis Dale 2026