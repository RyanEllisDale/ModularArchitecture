// Dependancies : 
using System.Collections.Generic;
using UnityEngine;
using ModularArchitecture.Events;

[RequireComponent(typeof(Renderer))]
public class EventSwapSample : MonoBehaviour
{
    [SerializeField] private List<Material> _materials;
    private int _currentIndex = 0;
    [SerializeField] private Renderer _renderer;
    [SerializeField] private GameEvent _gameEventTarget;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();

        if (_renderer == null)
        {
            Debug.LogError("Event Sample : Awake : Renderer could not be found, please attach renderer to script");
            return;
        }

        if (_materials.Count == 0)
        {
            Debug.LogError("Event Sample : Awake : Material List is empty, please add a material to material list");
            return;
        }

        _renderer.material = _materials[0];
    }


    [ContextMenu("Swap Material")]
    public void SwapMaterial()
    {
        if (_renderer == null)
        {
            Debug.LogError("Event Sample : SwapMaterial : Renderer could not be found, please attach renderer to script");
            return;
        }

        if (_materials.Count == 0)
        {
            Debug.LogError("Event Sample : SwapMaterial : Material List is empty, please add a material to material list");
            return;
        }

        _currentIndex = _currentIndex + 1;

        if (_currentIndex >= _materials.Count)
        {
            _currentIndex = 0;

            if (_gameEventTarget != null)
            {
                Debug.Log("Event Sample has rest it's material loop, and called it's game event.");
                _gameEventTarget.Raise();
            }
            else
            {
                Debug.LogError("Event Sample : SwapMaterial : Game Event Target is null, please set a game event target for this script.");
            }  
        }

        _renderer.material = _materials[_currentIndex];
    }
}
