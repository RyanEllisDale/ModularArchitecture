using UnityEngine;

public class RandomizeAttribute : PropertyAttribute
{
    public readonly float minValue;
    public readonly float maxValue;

    public RandomizeAttribute(float aMinValue, float aMaxValue)
    {
        this.minValue = aMinValue;
        this.maxValue = aMaxValue;
    }
}
