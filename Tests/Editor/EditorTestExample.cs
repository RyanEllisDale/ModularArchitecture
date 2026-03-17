// Edit Mode Editor Tester
// Will Create a new Runtime Example script then call it's print / start function
// Edit Mode Tests are ran from Test Runner : Edit Mode
    // Test Runner can be found at ( Window > General > Test Runner )

#if UNITY_EDITOR
// Dependancies : 
using NUnit.Framework;
using UnityEngine;

namespace PackageTemplate.Tests // Root Namespace declared in Assembly Definition
{
    public class EditModeExampleTest
    {
        [Test] // Edit Mode Tests
        public void TestRuntimeExampleEditMode()
        {
            // Creating Game Object and Runtime Script : 
            GameObject testGameObject = new GameObject();
            RuntimeExample runtimeExampleScript = testGameObject.AddComponent<RuntimeExample>();
            
            // Testing Runtime Script : 
            runtimeExampleScript.Start();
            Assert.IsNotNull(runtimeExampleScript);
            Debug.Log("Test Finished");
        }
    }
}
#endif

// Ryan Ellis Dale 2026