using UnityEngine;
using UnityEngine.UI;
using ModularArchitecture.Data;

public class ConditionSample : MonoBehaviour
{
    [SerializeField] private ConditionVariable _condition;
    [SerializeField] private Text _text;

    void Start()
    {
        Evaluate();
    }

    [ContextMenu("Evaluate Condition")]
    public void Evaluate()
    {
        if (_condition == null)
        {
            Debug.LogError("Condition Sample : Evaluate : Condition has not been set, please set condition to an appropriate data asset variable.");
            return;
        }

        _text.text = "Condition : " + "\"" + _condition.value.id + "\"" + " is " + _condition.value.Evaluate();
        Debug.Log("Condition : " + "\"" + _condition.value.id + "\"" + " was evaluated to be : " + _condition.value.Evaluate());
    }
}
