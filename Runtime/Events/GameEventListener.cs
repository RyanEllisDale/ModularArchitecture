// Dependancies : 
using UnityEngine;
using UnityEngine.Events;

namespace ModularArchitecture.Events
{
    /// <summary>
    /// Serialized Event Listener for scripts and classes to reference and activate for event responses <br/>
    /// Subscribes to a GameEvent Asset and when that event is raised it will invoke it's given response(s) <br/>
    /// Contains a Constructor so it can reference GameEvent data assets in the Unity Resources Folder <br/>
    /// Used as the listener for GameEventListenerScript <br/>
    /// </summary>
    [System.Serializable]
    public class GameEventListener
    {
        // Data Members : 
        public GameEvent gameEvent;
        public UnityEvent response;

        // Construction :
        public GameEventListener() { }

        /// <summary>
        /// Constructable script reference, will take a given GameEvent from a resources folder and attach a given unity action to it. <br/>
        /// Useful for when you cannot serialize the listener / you are using the listener from an asset instance or asset data file <br/>
        /// </summary>
        /// <param name="aGameEvent">The Game Event to subscribe to: <br/>Should be in a resource folder</param>
        /// <param name="aUnityAction">Thge responmse to trigger upon Game Event Raising</param>
        public GameEventListener(GameEvent aGameEvent, UnityAction aUnityAction)
        {
            gameEvent = aGameEvent;
            response = new UnityEvent();
            response.AddListener(aUnityAction);
        }

        // Data Methods : 
        [ContextMenu("Manual Subscription to Game Event")]
        public void SubscribeSelf() { gameEvent?.Subscribe(this); }
        [ContextMenu("Manual Unsubscription to Game Event")]
        public void UnsubscribeSelf() { gameEvent?.Unsubscribe(this); }
        [ContextMenu("Force Invoke")]
        public void OnEventRaised() { response?.Invoke(); }
    }
}
