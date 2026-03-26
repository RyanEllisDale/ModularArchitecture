using UnityEngine;
using UnityEngine.Events;

namespace ModularArchitecture
{
    // public class GameEventListener : MonoBehaviour
    // {
    //     public GameEvent gameEvent;
    //     public UnityEvent response;

    //     private void OnEnable() { gameEvent?.Subscribe(this); }
    //     private void OnDisable() { gameEvent?.UnSubscribe(this); }
    //     public void OnEventRaised() { response?.Invoke(); }
    // }

    [System.Serializable]
    public class GameEventListenerSerial
    {
        public GameEvent gameEvent;
        public UnityEvent response;

        public void OnEnable() { gameEvent?.Subscribe(this); }
        public void OnDisable() { gameEvent?.UnSubscribe(this); }
        public void OnEventRaised() { response?.Invoke(); }
    }
}
