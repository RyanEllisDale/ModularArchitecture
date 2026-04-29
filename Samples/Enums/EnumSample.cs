// Dependancies : 
using UnityEngine;
using ModularArchitecture.Enums;
using UnityEngine.UI;

public class EnumSample : MonoBehaviour
{
    [SerializeField] private ExtendableEnum<EnumExample> _example;
    [SerializeField] private EnumExample _storedValue;
    [SerializeField] private Text _text;
    
    // Update is called once per frame
    void Update()
    {
        if (_example == null)
        {
            Debug.LogError("Enum Sample : Update : Example has not been set, please set _example to an appropriate data asset variable.");
            return;
        }

        _text.text = "Enum Values :\n\n";
        foreach (EnumExample state in System.Enum.GetValues(typeof(EnumExample)))
        {
            _text.text = _text.text + (int)state + " " + state + "\n";
        }

        if (_storedValue == _example.value)
        {
            _text.text = _text.text + "\\nnThe stored value matches the Enum Example Value, both are : " + _storedValue;
            return;
        }

        _text.text = _text.text + "\n\nThe stored value does not match the Enum Example Value,\nStored Value: " + _storedValue + "\nExample Value: " + _example.value;
    }
}
