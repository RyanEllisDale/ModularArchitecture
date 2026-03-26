using System.Collections.Generic;
using UnityEngine;

namespace ModularArchitecture
{

    [CreateAssetMenu(menuName = "Modular/New Game Event")]
    public class GameEvent : ScriptableObject
    {
        private HashSet<GameEventListenerSerial> listeners = new HashSet<GameEventListenerSerial>();

        public void Raise()
        {
            foreach (GameEventListenerSerial listener in listeners)
            {
                listener.OnEventRaised();
            }

            Debug.Log("Event Raised");
        }    

        public void Subscribe(GameEventListenerSerial listener)
        {
            if (listeners.Contains(listener) == false) { listeners.Add(listener); }
        }

        public void UnSubscribe(GameEventListenerSerial listener)
        {
            if (listeners.Contains(listener) == true) { listeners.Remove(listener); }
        }
    }

}
