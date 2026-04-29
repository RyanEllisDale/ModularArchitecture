// Dependancies :
using UnityEngine;
using ModularArchitecture.Enums;

// Namespace : 
    public enum EnumExample
    {
        None,
	
    State1, State2 }
    
    [CreateAssetMenu(fileName = "EnumExample", menuName = "Modular/Enums/Enum : EnumExample", order = 1)]
    public class ExtendableEnumExample : ExtendableEnum<EnumExample>
    {
	    
    }