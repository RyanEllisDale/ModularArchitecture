using System;
using UnityEngine;

namespace ModularArchitecture
{
    public enum Comparison
    {
        Equal,
        NotEqual,
        Less, 
        LessEqual,
        Greater,
        GreaterEqual,
    }

    public enum Type
    {
        Int,
        Float,
        String,
        Bool
    }


    [System.Serializable]
    public class Condition 
    {
        [SerializeField] private string name;
        [SerializeField] private Type type = Type.Int;
        [SerializeField] private Comparison comparison = Comparison.Equal;
        [SerializeReference] private DataReferenceBase subject = new IntReference();
        [SerializeReference] private DataReferenceBase target = new IntReference();
        
        public bool Evaluate()
        {
            switch (comparison)
            {
                case Comparison.Equal: return subject == target; break;
                case Comparison.NotEqual: return subject != target; break;
                case Comparison.Less: return subject < target; break;
                case Comparison.LessEqual: return subject <= target; break;
                case Comparison.Greater: return subject > target; break;
                case Comparison.GreaterEqual: return subject >= target; break;

                default: Debug.LogError("Unhandled Condition: Modular Architecture: Condition: Evaluate\nCondition: " + name + " Type: " + type + " Comparison: " + comparison); break;
            }
            
            return false; 
        }




    }
}
