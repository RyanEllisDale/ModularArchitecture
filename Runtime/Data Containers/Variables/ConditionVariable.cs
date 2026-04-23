using UnityEngine;

namespace ModularArchitecture
{
    [CreateAssetMenu(fileName = "New Condition Variable", menuName = "Modular/Data/New Condition", order = 1)]
    public class ConditionVariable : DataContainer<Condition> {}
}