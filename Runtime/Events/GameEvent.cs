using System.Collections.Generic;
using UnityEngine;

namespace ModularArchitecture
{

    [CreateAssetMenu(menuName = "Modular/New Game Event")]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners;

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

        public void UnSubscribe(GameEventListener listener)
        {
            if (listeners.Contains(listener) == true) { listeners.Remove(listener); }
        }
    }

}
