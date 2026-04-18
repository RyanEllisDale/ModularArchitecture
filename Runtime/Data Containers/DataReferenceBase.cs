// Dependancies : 
using System;

// Resources : 
// https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-10.0

namespace ModularArchitecture
{
    /// <summary>
        /// DataRefernceBase is the base class used to draw, overload, and compare for DataRefence <br/>
        /// DataReference is a generic templated type and thus cannot be the target of property drawers or comparisons so DataReferenceBase is used instead <br/>
        /// DataReferenceBase contains the base == equality overloads that DataReference needs to overwrite so it's values can be compared to other References <br/>
    /// </summary>
    [System.Serializable]
    public abstract class DataReferenceBase : IComparable<DataReferenceBase>
    {
        // Comparison Interface : 
        // Allows Classes to compare bases, implementation is overloaded in DataReference<T> to use the comparison in it's generic Type
        // All Overloads use CompareTo so the implementation of comparisons is universal in DataReference<T>
        public abstract int CompareTo(DataReferenceBase other);

        // IComparable Operator Overloads : 
        // All overloads use CompareTo which will be overwritten in DataReference<T> making them generic and transferable
        public static bool operator <(DataReferenceBase a, DataReferenceBase b) => a.CompareTo(b) < 0;
        public static bool operator >(DataReferenceBase a, DataReferenceBase b) => a.CompareTo(b) > 0;
        public static bool operator <=(DataReferenceBase a, DataReferenceBase b) => a.CompareTo(b) <= 0;
        public static bool operator >=(DataReferenceBase a, DataReferenceBase b) => a.CompareTo(b) >= 0;

        // Equality Overloading : 
        // Used for basic comparisons and lists
        public static bool operator ==(DataReferenceBase a, DataReferenceBase b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;

            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(DataReferenceBase a, DataReferenceBase b) => !(a == b);
        public override bool Equals(object obj) => this == obj as DataReferenceBase;
        public override int GetHashCode() => base.GetHashCode();
    }

}