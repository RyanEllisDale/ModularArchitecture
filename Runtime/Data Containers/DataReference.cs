// Dependancies :
using System;

// Resources :
// https://youtu.be/raQ3iHhE_Kk?si=vPNxUAdLeB1wycK_
// https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-10.0

namespace ModularArchitecture
{
    /// <summary>
    /// DataReference contains either a constant value or points to a data container asset in the project <br/>
    /// It is used in place of default types to reference variable objects and allow for implicit comparisons. <br/>
    /// It contains types that are comparable ( consist of IComperable ), so that custom types can be made <br/>
    /// </summary>
    /// <typeparam name="T">A comparable type that can be in a data asset (DataContainer)</typeparam>
    [System.Serializable]
    public class DataReference<T> : DataReferenceBase where T : IComparable<T>
    {
        // Data Members :
        public bool useConstant = true;
        public T constantValue; 
        public DataContainer<T> variable;

        // Absolute Value Variable : 
        public T value 
        {
            get {   return useConstant ? constantValue : variable.value; }
            set {   if (useConstant == true) { constantValue = value; }
                    else { variable.value = value; } 
                }
        }

        // Construction : 
        // Default Empty Construction :
        public DataReference() {}
        // Built Value Construction ( Uses Constant Value ) :
        public DataReference(T value) 
        {
            useConstant = true;
            constantValue = value;
        }

        // Comparisonm Overloader from DataReferenceBase : 
        /// Used to define over arithmetic and comparison operators in DataReferenceBase since value is IComparable. 
        public override int CompareTo(DataReferenceBase other)
        {
            if (other is DataReference<T> typed)
                return this.value.CompareTo(typed.value);

            throw new ArgumentException("Cannot compare different DataReference types");
        }

        // Comparison Overloader : 
        public static implicit operator T(DataReference<T> reference) => reference.value;
    }

    // Generic Reference Wrapper Types :
    [System.Serializable] public class FloatReference : DataReference<float> {}
    [System.Serializable] public class StringReference : DataReference<string> {}
    [System.Serializable] public class IntReference : DataReference<int> {}
    [System.Serializable] public class BoolReference : DataReference<bool> {}

}