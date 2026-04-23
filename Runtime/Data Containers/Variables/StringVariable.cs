using UnityEngine;

namespace ModularArchitecture
{
    [CreateAssetMenu(fileName = "New String Variable", menuName = "Modular/Data/New String", order = 0)]
    public class StringVariable : DataContainer<string> {}
}