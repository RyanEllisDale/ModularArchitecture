// Dependancies : 
//#if UNITY_EDITOR
using UnityEditor;
using ModularArchitecture;
using UnityEngine;

/// <summary>
/// EDITOR ONLY : Small Sample Script that takes an input and tests a given condition. <br/>
/// </summary>
public class ConditionTester : MonoBehaviour
{
    // Data Members : 
    [SerializeField] private DataReference<Condition> condition;
    [SerializeField] private KeyCode key;
    [SerializeField] private bool onStart = false;

    // Data Methods : 
    public void Start()
    {
        if (onStart == true)
        {
            Activate();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(key) == true)
        {
            Activate();
        }
    }

    [ContextMenu("Print Condition Evaluation")]
    private void Activate()
    {
        Debug.Log("Condition Tester Activated");

        condition.value.DEBUGPrintEvaluation();
        //condition.value.Evaluate();
        //condition.value.DEBUGPrintEvaluation();
    }

}
//#endif