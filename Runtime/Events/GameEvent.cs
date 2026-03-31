using System.Collections.Generic;
using UnityEngine;

namespace ModularArchitecture
{
    [CreateAssetMenu(menuName = "Modular/New Game Event")]
    public class GameEvent : ScriptableObject
    {
        private HashSet<GameEventListener> listeners = new HashSet<GameEventListener>();

        public void Raise()
        {
            foreach (GameEventListener listener in listeners)
            {
                listener.OnEventRaised();
            }
        }    

        public void Subscribe(GameEventListener listener)
        {
            if (listeners.Contains(listener) == false) { listeners.Add(listener); }
        }

        public void Unsubscribe(GameEventListener listener)
        {
            if (listeners.Contains(listener) == true) { listeners.Remove(listener); }
        }
    }

}
