using UnityEngine;
using UnityEditor;
using ModularArchitecture;


namespace ModularArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(Condition))]
    public class ConditionDrawer : PropertyDrawer
    {
        // Helper function to set the reference type dynamically
        public void EnsureReferenceType(SerializedProperty prop, System.Type t)
        {
            object currentObj = prop.managedReferenceValue;
            if (currentObj == null || currentObj.GetType() != t)
            {
                prop.managedReferenceValue = System.Activator.CreateInstance(t);
            }
        }


        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Get serialized properties
            SerializedProperty nameProp = property.FindPropertyRelative("name");
            SerializedProperty typeProp = property.FindPropertyRelative("type");
            SerializedProperty subjectProp = property.FindPropertyRelative("subject");
            SerializedProperty targetProp = property.FindPropertyRelative("target");
            SerializedProperty comparisonProp = property.FindPropertyRelative("comparison");

            // Draw the foldout label
            position.height = EditorGUIUtility.singleLineHeight;
            property.isExpanded = EditorGUI.Foldout(position, property.isExpanded, label, true);
            if (!property.isExpanded) return;

            if (subjectProp.managedReferenceValue == null)
            {
                subjectProp.managedReferenceValue = new IntReference(); // default type
            }

            if (targetProp.managedReferenceValue == null)
            {
                targetProp.managedReferenceValue = new IntReference();
            }

            EditorGUI.indentLevel++;


            position.y += EditorGUIUtility.singleLineHeight + 2;
            EditorGUI.PropertyField(position, nameProp);
            
            // Draw Type Enum
            position.y += EditorGUIUtility.singleLineHeight + 2;
            EditorGUI.PropertyField(position, typeProp);

            // Check the selected type
            Type selectedType = (Type)typeProp.enumValueIndex;


            // Map the Type enum to the correct concrete class
            System.Type concreteType = selectedType switch
            {
                Type.Int => typeof(IntReference),
                Type.Float => typeof(FloatReference),
                Type.String => typeof(StringReference),
                Type.Bool => typeof(BoolReference),
                _ => typeof(FloatReference)
            };

            // Ensure subject and target have the correct concrete type
            EnsureReferenceType(subjectProp, concreteType);
            EnsureReferenceType(targetProp, concreteType);

            // Draw subject and target fields

            position.y += EditorGUIUtility.singleLineHeight + 2;
            EditorGUI.PropertyField(position, subjectProp);

            position.y += EditorGUI.GetPropertyHeight(subjectProp) + 2;
            EditorGUI.PropertyField(position, targetProp);

            // Draw comparison
            position.y += EditorGUI.GetPropertyHeight(targetProp) + 2;
            EditorGUI.PropertyField(position, comparisonProp);

            EditorGUI.indentLevel--;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (!property.isExpanded) return EditorGUIUtility.singleLineHeight;

            SerializedProperty typeProp = property.FindPropertyRelative("type");
            SerializedProperty subjectProp = property.FindPropertyRelative("subject");
            SerializedProperty targetProp = property.FindPropertyRelative("target");
            SerializedProperty comparisonProp = property.FindPropertyRelative("comparison");

            float height = 0;
            height += EditorGUIUtility.singleLineHeight + 2;
            height += EditorGUIUtility.singleLineHeight + 2; // foldout
            height += EditorGUIUtility.singleLineHeight + 2; // type
            height += EditorGUI.GetPropertyHeight(subjectProp) + 2; // subject
            height += EditorGUI.GetPropertyHeight(targetProp) + 2; // target
            height += EditorGUIUtility.singleLineHeight + 2; // comparison

            return height;
        }
    }
}