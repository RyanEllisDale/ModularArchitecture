using UnityEngine;
using UnityEngine.Events;

namespace ModularArchitecture
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent gameEvent;
        public UnityEvent response;

        private void OnEnable() { gameEvent?.Subscribe(this); }
        private void OnDisable() { gameEvent?.UnSubscribe(this); }
        public void OnEventRaised() { response?.Invoke(); }
    }
}
