using UnityEditor;
using UnityEngine;
using ModularArchitecture;

namespace ModularArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(DataReferenceBase), true)]
    public class DataReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var useConstant = property.FindPropertyRelative("useConstant");
            var constant = property.FindPropertyRelative("constantValue");
            var variable = property.FindPropertyRelative("variable");

            const float buttonWidth = 70;
            const float spacing = 10;

            Rect labelRect = new Rect(position.x, position.y, EditorGUIUtility.labelWidth, position.height);
            Rect buttonRect = new Rect(position.x + EditorGUIUtility.labelWidth, position.y, buttonWidth - spacing, position.height);
            Rect fieldRect = new Rect(position.x + EditorGUIUtility.labelWidth + buttonWidth, position.y, position.width - EditorGUIUtility.labelWidth - buttonWidth, position.height);
            
            EditorGUI.LabelField(labelRect, label);

            useConstant.boolValue = GUI.Toggle(buttonRect, useConstant.boolValue, useConstant.boolValue ? "Const" : "Ref", EditorStyles.miniButton);

            if (useConstant.boolValue)
            {
                EditorGUI.PropertyField(fieldRect, constant, GUIContent.none);
            }
            else
            {
                EditorGUI.PropertyField(fieldRect, variable, GUIContent.none);
            }
        }
    }
}