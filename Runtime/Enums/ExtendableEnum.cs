// Dependancies : 
using UnityEngine;

namespace ModularArchitecture
{
    /// <summary>
    /// A small data asset that uses Cory Koseck's Extend Enums to create a modular enum container that can be referenced and added to overtime. 
    /// </summary>
    /// <typeparam name="T">An Enum type to be put into the extendable data container</typeparam>
    public class ExtendableEnum<T> : ScriptableObject where T : System.Enum
    {
        [ExtendEnum] public T value;
    }
}
