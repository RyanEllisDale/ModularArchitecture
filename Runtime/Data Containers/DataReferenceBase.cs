using System;
using UnityEngine;

namespace ModularArchitecture
{
    [System.Serializable]
    public abstract class DataReferenceBase : IComparable<DataReferenceBase>
    {
        public abstract int CompareTo(DataReferenceBase other);

        public static bool operator ==(DataReferenceBase a, DataReferenceBase b)
        {
            // Handle null cases
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;

            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(DataReferenceBase a, DataReferenceBase b)
            => !(a == b);

        public override bool Equals(object obj)
            => this == obj as DataReferenceBase;

        public override int GetHashCode()
            => base.GetHashCode();

        public static bool operator <(DataReferenceBase a, DataReferenceBase b)
            => a.CompareTo(b) < 0;

        public static bool operator >(DataReferenceBase a, DataReferenceBase b)
            => a.CompareTo(b) > 0;

        public static bool operator <=(DataReferenceBase a, DataReferenceBase b)
            => a.CompareTo(b) <= 0;

        public static bool operator >=(DataReferenceBase a, DataReferenceBase b)
            => a.CompareTo(b) >= 0;
    }

}