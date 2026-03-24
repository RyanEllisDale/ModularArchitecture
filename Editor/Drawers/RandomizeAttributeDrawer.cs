using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(RandomizeAttribute))]
public class RandomizeAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Rect labelPosition = new Rect(position.x, position.y, position.width, 16f);
        Rect buttonPosition = new Rect(position.x, position.y + labelPosition.height, position.width, 16f);

        EditorGUI.LabelField(labelPosition, label, new GUIContent(property.floatValue.ToString()));
        if (GUI.Button(buttonPosition, "Randomize"))
        {
            RandomizeAttribute random = (RandomizeAttribute)attribute;
            property.floatValue = Random.Range(random.minValue, random.maxValue);
        }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return 32f;
    }




}
