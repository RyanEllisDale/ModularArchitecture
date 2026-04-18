// Dependancies : 
using UnityEngine;

namespace ModularArchitecture
{
    /// <summary>
    /// MonoBehaviour script class for serialized GameEventListener <br/>
    /// Allows for component-based use of GameEventListener within scene, so GameEventListener works in assets and scenes. 
    /// </summary>
    public class GameEventListenerScript : MonoBehaviour
    {
        // Data Members : 
        [SerializeField] private GameEventListener listener;

        // Data Functions:
        // Subscribes and Unsubscribes itself in scope to the given event. 
        [ContextMenu("Manual Subscription to Game Event")]
        public void OnEnable() { listener.SubscribeSelf(); }
        [ContextMenu("Manual Unsubscription to Game Event")]
        public void OnDisable() { listener.UnsubscribeSelf(); }
        [ContextMenu("Force Invoke")]
        public void OnEventRaised() { listener.OnEventRaised(); }
    }
}
