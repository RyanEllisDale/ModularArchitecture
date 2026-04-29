// Dependancies : 
using System;
using UnityEngine;
using ModularArchitecture.Data;

// Resources :
// https://discussions.unity.com/t/basic-ai-modular-conditions/898833

namespace ModularArchitecture.Conditions
{
    public enum ConditionComparison
    {
        Equal,
        NotEqual,
        Less, 
        LessEqual,
        Greater,
        GreaterEqual,
    }

    public enum ConditionValueType
    {
        Int,
        Float,
        String,
        Bool
    }

    /// <summary>
    /// Serialized Condition Class that will compare two references together based on a given comparison operator. <br/>
    /// Condition has it's own drawer that will set the subject and target to be references of the given Value Type. 
    /// </summary>
    [System.Serializable]
    public class Condition : IComparable<Condition>
    {
        // Data Members :
        public string id;
        [Tooltip("The wrapper type for your reference, must be set to the correct type before you can add variable references to subject and target")]
        [SerializeField] private ConditionValueType _type = ConditionValueType.Int;
        [Tooltip("The comparison operator to use (standard IComparable arithmetic operators)")]
        [SerializeField] private ConditionComparison _comparison = ConditionComparison.Equal;
        [Tooltip("The subject will be compared to the target, so subject should be used as the current value whilst target is considered the goal value")]
        [SerializeReference] private DataReferenceBase _subject = new IntReference();
        [Tooltip("The subject will be compared to the target, so subject should be used as the current value whilst target is considered the goal value")]
        [SerializeReference] private DataReferenceBase _target = new IntReference();

        /// <summary>
        /// Evaluates the condition by comparing the subject against the target <br/>
        /// DataReference Types are IComparable and thus the comparison is based off the types operations.
        /// </summary>
        /// <returns>Returns true or false depending on wether the condition's evaluation was successful or not</returns>
        public bool Evaluate()
        {
            switch (_comparison)
            {
                case ConditionComparison.Equal: return _subject == _target; break;
                case ConditionComparison.NotEqual: return _subject != _target; break;
                case ConditionComparison.Less: return _subject < _target; break;
                case ConditionComparison.LessEqual: return _subject <= _target; break;
                case ConditionComparison.Greater: return _subject > _target; break;
                case ConditionComparison.GreaterEqual: return _subject >= _target; break;

                default: Debug.LogError("Unhandled Condition: Modular Architecture: Condition: Evaluate\nCondition: " + id + " Type: " + _type + " Comparison: " + _comparison); break;
            }
            
            return false; 
        }

        public int CompareTo(Condition other)
        {
            throw new NotImplementedException();
        }

        // Debugging : 
        
        #if UNITY_EDITOR
        /// <summary>
        /// Debug Function for logging the evaluation of the condition. 
        /// </summary>
        /// <returns>The evaluation result that is logged</returns>
        public bool DEBUGPrintEvaluation()
        {
            bool evaluationResult = Evaluate();
            Debug.Log(evaluationResult);
            return evaluationResult;
        }
        #endif

    }
}
