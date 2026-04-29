using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class EventToggleSample : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();

        if (_renderer == null)
        {
            Debug.LogError("Event Toggle Sample : Awake : Renderer could not be found, please attach renderer to script");
            return;
        }

        _renderer.enabled = true;
    }

    void Start()
    {
        if (_renderer == null)
        {
            Debug.LogError("Event Toggle Sample : Start : Renderer could not be found, please attach renderer to script");
            return;
        }

        _renderer.enabled = true;
    }

    [ContextMenu("Toggle Renderer")]
    public void ToggleRenderer()
    {
        if (_renderer == null)
        {
            Debug.LogError("Event Toggle Sample : ToggleRenderer : Renderer could not be found, please attach renderer to script");
            return;
        }

        _renderer.enabled = !_renderer.enabled;
    }

}
