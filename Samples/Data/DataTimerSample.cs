// Dependancies : 
using ModularArchitecture.Data;
using UnityEngine;
using UnityEngine.UI;

public class DataTimerSample : MonoBehaviour
{
    [SerializeField] private DataReference<float> _time;
    private float _currentTime;
    [SerializeField] private Text _timeText;

    // Update is called once per frame
    void Update()
    {
        if (_time == null)
        {
            Debug.LogError("Data Time Sample : Update : Time has not been set, please set _time to an appropriate data asset variable.");
            return;
        }


        _currentTime = _currentTime + Time.deltaTime;
        if (_currentTime >= _time.value)
        {
            _currentTime = 0;
        }

        _timeText.text = "Current Time : " + _currentTime.ToString("F3") + "\nResets at : " + _time.value.ToString("F3");
    }
}
