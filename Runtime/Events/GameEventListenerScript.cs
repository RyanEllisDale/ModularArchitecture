using UnityEngine;

namespace ModularArchitecture
{
    public class GameEventListenerScript : MonoBehaviour
    {
        [SerializeField] private GameEventListener listener;

        public void OnEnable() { listener.SubscribeSelf(); }              
        public void OnDisable() { listener.UnsubscribeSelf(); }
        public void OnEventRaised() { listener.OnEventRaised(); }
    }
}
