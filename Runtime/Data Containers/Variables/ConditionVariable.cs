using UnityEngine;
using ModularArchitecture.Conditions;

namespace ModularArchitecture.Data
{
    [CreateAssetMenu(fileName = "New Condition Variable", menuName = "Modular/Data/New Condition", order = 1)]
    public class ConditionVariable : DataContainer<Condition> {}
}