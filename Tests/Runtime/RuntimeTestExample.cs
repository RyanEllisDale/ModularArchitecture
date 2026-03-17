// Play Mode Editor Tester
// Starts up a testing instance, 
    // In this instance a game object is created, 
    // Then a runtime example script is added to that game object, 
    // Finally script's print / start function is called

// Play Mode Tests are ran from Test Runner : Play Mode
    // Test Runner can be found at ( Window > General > Test Runner )

#if UNITY_EDITOR
// Dependancies : 
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;

namespace PackageTemplate.Tests // Root Namespace declared in Assembly Definition
{
    public class RuntimeTestExample
    {
        [UnityTest] // Play Mode Tests
        public IEnumerator TestRuntimeExamplePlayMode()
        {
            // Create the object and Script : 
            GameObject testGameObject = new GameObject();
            RuntimeExample runtimeExampleScript = testGameObject.AddComponent<RuntimeExample>();
            
            // Run the Script : 
            runtimeExampleScript.Start();
            yield return null;

            // Cleanup :
            Assert.IsNotNull(runtimeExampleScript);
            Object.Destroy(testGameObject);
            Debug.Log("Test Finished");
        }
    }
}
#endif

// Ryan Ellis Dale 2026