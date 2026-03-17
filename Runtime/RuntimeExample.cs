// Miniture runtime script that saves and prints string variable, 
// This runtime script has it's own editor in Editor/EditorExample
// This runtime script has it's own tests in Tests/Runtime + Tests/Editor

// Dependancies : 
using UnityEngine;

namespace PackageTemplate // Root Namespace declared in Assembly Definition
{
    public class RuntimeExample : MonoBehaviour
    {
        [SerializeField] public string example = "Example Value";

        public void Start()
        {
            Debug.Log(example);
        }
    }
}

// Ryan Ellis Dale 2026