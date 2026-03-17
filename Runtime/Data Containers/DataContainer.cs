using UnityEngine;

namespace ModularArchitecture
{
    public abstract class DataContainer<T> : ScriptableObject
    {
        public T value;
        public static implicit operator T(DataContainer<T> aVariable) { return aVariable.value; }
    }
}
