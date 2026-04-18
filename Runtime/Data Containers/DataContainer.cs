// Dependancies :
using UnityEngine;

namespace ModularArchitecture
{
    /// <summary>
    /// A Asset File containing a value of any given type <br/>
    /// Used for modular / data-driven design, and referenced in DataReference. <br/>
    /// DataContainer is an abstract class because Unity cannot make generic Scriptable Objects <br/>
    /// Any Child of DataContainer ( different types ) should be made wrapper children.
    /// </summary>
    /// <typeparam name="T">Templated Type Field for any type that can be stored in a data object</typeparam>
    public abstract class DataContainer<T> : ScriptableObject
    {
        public T value;
        public static implicit operator T(DataContainer<T> aVariable) { return aVariable.value; }
    }
}
