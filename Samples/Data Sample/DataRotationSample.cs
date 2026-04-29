// Dependancies : 
using UnityEngine;

namespace ModularArchitecture.Data
{
    public class DataRotationSample : MonoBehaviour
    {
        [SerializeField] private DataReference<float> _rotation;

        private void Update()
        {
            transform.Rotate(0, 0, _rotation.value * Time.deltaTime);
        }
    }
}