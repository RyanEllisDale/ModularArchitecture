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
        
        public bool Evaluate() { return true; }
    }
}
