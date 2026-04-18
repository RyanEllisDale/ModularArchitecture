using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularArchitecture
{
    [System.Serializable]
    public class DataReference<T> : DataReferenceBase where T : IComparable<T>
    {
        public bool useConstant = true;
        public T constantValue; 
        public DataContainer<T> variable;

        public T value 
        {
            get {   return useConstant ? constantValue : variable.value; }
            set {   if (useConstant == true) { constantValue = value; }
                    else { variable.value = value; } 
                }
        }

        public DataReference() {}
        public DataReference(T value) 
        {
            useConstant = true;
            constantValue = value;
        }

        public static implicit operator T(DataReference<T> reference)
        {
            return reference.value;
        }

        //public int CompareTo(DataReference<T> other)
        //{
        //    Debug.Log("Comparison Being Made");


        //    if (other == null)
        //        return 1;

        //    return this.value.CompareTo(other.value);
        //}

        public override int CompareTo(DataReferenceBase other)
        {
            Debug.Log("Comparison Being Made");

            if (other is DataReference<T> typed)
                return this.value.CompareTo(typed.value);


            throw new ArgumentException("Cannot compare different DataReference types");
        }






    }

    [System.Serializable]
    public class FloatReference : DataReference<float> {}
    [System.Serializable]
    public class StringReference : DataReference<string> {}
    [System.Serializable]
    public class IntReference : DataReference<int> {}
    [System.Serializable]
    public class BoolReference : DataReference<bool> {}

}