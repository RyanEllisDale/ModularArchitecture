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
            SerializedProperty useConstant = property.FindPropertyRelative("useConstant");
            SerializedProperty constant = property.FindPropertyRelative("constantValue");
            SerializedProperty variable = property.FindPropertyRelative("variable");

            SerializedProperty activeProp = useConstant.boolValue ? constant : variable;

            const float buttonWidth = 70;
            const float spacing = 5;

            float lineHeight = EditorGUIUtility.singleLineHeight;

            Rect labelRect = new Rect(position.x, position.y, EditorGUIUtility.labelWidth, lineHeight);
            Rect buttonRect = new Rect(position.x + EditorGUIUtility.labelWidth, position.y, buttonWidth, lineHeight);

            float propHeight = EditorGUI.GetPropertyHeight(activeProp, true);

            bool multiline = propHeight > lineHeight;

            EditorGUI.LabelField(labelRect, label);

            useConstant.boolValue = GUI.Toggle(
                buttonRect,
                useConstant.boolValue,
                useConstant.boolValue ? "Const" : "Ref",
                EditorStyles.miniButton
            );

            if (multiline)
            {
                // Draw property BELOW
                Rect fieldRect = new Rect(
                    position.x,
                    position.y + lineHeight + EditorGUIUtility.standardVerticalSpacing,
                    position.width,
                    propHeight
                );

                EditorGUI.PropertyField(fieldRect, activeProp, true);
            }
            else
            {
                // Draw property INLINE
                Rect fieldRect = new Rect(
                    position.x + EditorGUIUtility.labelWidth + buttonWidth + spacing,
                    position.y,
                    position.width - EditorGUIUtility.labelWidth - buttonWidth - spacing,
                    lineHeight
                );

                EditorGUI.PropertyField(fieldRect, activeProp, GUIContent.none);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty useConstant = property.FindPropertyRelative("useConstant");
            SerializedProperty constant = property.FindPropertyRelative("constantValue");
            SerializedProperty variable = property.FindPropertyRelative("variable");

            SerializedProperty activeProp = useConstant.boolValue ? constant : variable;

            float baseHeight = EditorGUIUtility.singleLineHeight;

            float propHeight = EditorGUI.GetPropertyHeight(activeProp, true);

            // If it's more than one line, stack vertically
            if (propHeight > baseHeight)
            {
                return baseHeight + propHeight + EditorGUIUtility.standardVerticalSpacing;
            }

            return baseHeight;
        }

    }
}