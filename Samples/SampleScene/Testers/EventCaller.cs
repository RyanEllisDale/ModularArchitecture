#if UNITY_EDITOR
using UnityEditor;
using ModularArchitecture.Events;
using UnityEngine;

namespace ModularArchitecture.Testing
{
    public class EventCaller : MonoBehaviour
    {
        [SerializeField] private GameEvent gameEvent;
        [SerializeField] private KeyCode key; 
        [SerializeField] private bool onStart = false;

        public void Start()
        {
            if (onStart == true)
            {
                Activate();
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(key) == true)
            {
                Activate();
            }
        }

        [ContextMenu("Activate")]
        private void Activate()
        {
            gameEvent?.Raise();
        }
    }
}
#endif