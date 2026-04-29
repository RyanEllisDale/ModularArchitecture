// Dependancies : 
using UnityEngine;

namespace ModularArchitecture.Enums
{
    /// <summary>
    /// A modular enum container based on Cory Koseck's Extendable Enums pattern. <br/>
    /// Allows enum values to be represented as ScriptableObjects, enabling designers to
    /// extend enum‑like systems without modifying source code. <br/><br/>
    /// Contains : <br/>
    /// <b>- value :</b> The enum value stored in this asset. <br/>
    /// </summary>
    /// <typeparam name="T">The enum type represented by this extendable asset.</typeparam>
    public class ExtendableEnum<T> : ScriptableObject where T : System.Enum
    {
        /// <summary>
        /// The enum value represented by this asset.
        /// </summary>
        [ExtendEnum] public T value;
    }
}
