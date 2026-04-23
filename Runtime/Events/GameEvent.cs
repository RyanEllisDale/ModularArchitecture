// Dependancies : 
using System.Collections.Generic;
using UnityEngine;

namespace ModularArchitecture
{
    /// <summary>
    /// GameEvent object, when raised it will trigger responses from all listeners, <br/>
    /// Is a scriptable object asset file and thus works on its own without scene dependancy. <br/>
    /// Can only contain unique listeners, duplicate listeners will be ignored for performance and scale-ability.
    /// </summary>
    [CreateAssetMenu(fileName = "New Game Event", menuName = "Modular/Data/New Game Event", order = 1)]
    public class GameEvent : ScriptableObject
    {
        // Data Members :
        private HashSet<GameEventListener> listeners = new HashSet<GameEventListener>();

        // Data Methods : 
        [ContextMenu("Raise Event")]
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
