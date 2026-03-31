using UnityEngine;
using UnityEngine.Events;

namespace ModularArchitecture 
{
    [System.Serializable]
    public class GameEventListener
    {
        public GameEvent gameEvent;
        public UnityEvent response;

        public void SubscribeSelf() { gameEvent?.Subscribe(this); }
        public void UnsubscribeSelf() { gameEvent?.Unsubscribe(this); }
        public void OnEventRaised() { response?.Invoke(); }

        public GameEventListener(GameEvent aGameEvent, UnityAction aUnityAction)
        {
            gameEvent = aGameEvent;

            response = new UnityEvent();
            response.AddListener(aUnityAction);


        }
        public GameEventListener() {}

    }
}
