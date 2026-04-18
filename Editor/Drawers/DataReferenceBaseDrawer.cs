// Dependancies : 
using UnityEditor;
using UnityEngine;

namespace ModularArchitecture.Editor
{
    // Draws Wrappers of Data Reference variables by targetting the base and building from there, 
    // Draws a toggle button that swaps between constant values and variable asset values,
        // Constant values use the default drawing field for the relevant type
        // Variable values are references so they use the default input field           

    [CustomPropertyDrawer(typeof(DataReference<>), true)]
    public class DataReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Data : 
            // Stores the SerializedProperties of Data Reference ( missing from base ) but will be in wrapper children
            SerializedProperty useConstant = property.FindPropertyRelative("useConstant");
            SerializedProperty constant = property.FindPropertyRelative("constantValue");
            SerializedProperty variable = property.FindPropertyRelative("variable");

            const float buttonWidth = 70;
            const float spacing = 10;

            // Drawing the default fields : 
            Rect labelRect = new Rect(position.x, position.y, EditorGUIUtility.labelWidth, position.height);
            Rect buttonRect = new Rect(position.x + EditorGUIUtility.labelWidth, position.y, buttonWidth - spacing, position.height);
            Rect fieldRect = new Rect(position.x + EditorGUIUtility.labelWidth + buttonWidth, position.y, position.width - EditorGUIUtility.labelWidth - buttonWidth, position.height);
            EditorGUI.LabelField(labelRect, label);
            
            // Button Toggle : 
            useConstant.boolValue = GUI.Toggle(buttonRect, useConstant.boolValue, useConstant.boolValue ? "Const" : "Ref", EditorStyles.miniButton);
            if (useConstant.boolValue)
                EditorGUI.PropertyField(fieldRect, constant, GUIContent.none);
            else
                EditorGUI.PropertyField(fieldRect, variable, GUIContent.none);

        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty useConstant = property.FindPropertyRelative("useConstant");
            SerializedProperty constant = property.FindPropertyRelative("constantValue");
            SerializedProperty variable = property.FindPropertyRelative("variable");

            float height = 0;

            if (useConstant.boolValue == true)
            {
                height = height + EditorGUI.GetPropertyHeight(constant);
                return height;
            }

            height = height + EditorGUI.GetPropertyHeight(variable);

            return height;
        }
    }
}