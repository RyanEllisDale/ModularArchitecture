// Dependancies : 
using UnityEditor;
using UnityEngine;

namespace ModularArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(Condition))]
    public class ConditionDrawer : PropertyDrawer
    {
        /// <summary>
        /// Overwrites the serialized property type of a property to the given reference type if the property is null or not already that type. <br/>
        /// Used to define what dataReference type the subject and target of a condition will be based on the Condition's type property
        /// </summary>
        /// <param name="aProperty">The Reference property to overwrite the type of</param>
        /// <param name="aReferenceType">The system type that the reference property should become</param>
        public void SetReferenceType(SerializedProperty aProperty, System.Type aReferenceType)
        {
            object referenceValue = aProperty.managedReferenceValue;
            if (referenceValue == null || referenceValue.GetType() != aReferenceType)
            {
                aProperty.managedReferenceValue = System.Activator.CreateInstance (aReferenceType);
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {            
            // Foldout :
            // If the GUI is not expanded then only draw it's label and return
            position.height = EditorGUIUtility.singleLineHeight;
            property.isExpanded = EditorGUI.Foldout(position, property.isExpanded, label, true);
            if (!property.isExpanded) return;

            // Data : 
            // Store the serialized properties for the conditions so we can render and manipulate them
            SerializedProperty idProp = property.FindPropertyRelative("id");
            SerializedProperty typeProp = property.FindPropertyRelative("_type");
            SerializedProperty comparisonProp = property.FindPropertyRelative("_comparison");
            SerializedProperty subjectProp = property.FindPropertyRelative("_subject");
            SerializedProperty targetProp = property.FindPropertyRelative("_target");
            
            // Default Types:
            // if the target or subject is null default them to IntReferences
            if (subjectProp.managedReferenceValue == null)
                subjectProp.managedReferenceValue = new IntReference(); 
           
            if (targetProp.managedReferenceValue == null)
                targetProp.managedReferenceValue = new IntReference();

            // Drawing non-subject/target Data Fields ( id, Type, Comparison ) 
            // Indents the field after each line for rendering space
            EditorGUI.indentLevel++;
            position.y += EditorGUIUtility.singleLineHeight + 2;
            EditorGUI.PropertyField(position, idProp);
            position.y += EditorGUI.GetPropertyHeight(idProp);
            EditorGUI.PropertyField(position, typeProp);
            position.y += EditorGUI.GetPropertyHeight(targetProp) + 2;
            EditorGUI.PropertyField(position, comparisonProp);

            // Switching the subkect and target type dynamically : 
            // Get the current selected type and convert it to the relevant System Reference type
            // Map the Type enum to the correct concrete class
            ConditionValueType selectedType = (ConditionValueType)typeProp.enumValueIndex;
            System.Type concreteType = typeof(IntReference);
            switch (selectedType)
            {
                case ConditionValueType.Int: concreteType = typeof(IntReference); break;
                case ConditionValueType.Float: concreteType = typeof(FloatReference); break;
                case ConditionValueType.String: concreteType = typeof(StringReference); break;
                case ConditionValueType.Bool: concreteType = typeof(BoolReference); break;
                default: Debug.LogError("Unhandled ConditionValueType: Modular Architecture: ConditionDrawer: Drawing\n" +
                        "Condition: " + idProp.ToString() + " Type: " + typeProp.ToString() + " Comparison: " + comparisonProp.ToString()); break;
            }

            // Ensure subject and target have the correct concrete type
            SetReferenceType(subjectProp, concreteType);
            SetReferenceType(targetProp, concreteType);

            // Draw subject and target fields
            position.y += EditorGUIUtility.singleLineHeight + 2;
            EditorGUI.PropertyField(position, subjectProp);
            position.y += EditorGUI.GetPropertyHeight(subjectProp) + 2;
            EditorGUI.PropertyField(position, targetProp);
            EditorGUI.indentLevel--;
        }

        // Drawer Height :
        // Made by indenting single line height by the amount of fields and foldout. 
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (!property.isExpanded) return EditorGUIUtility.singleLineHeight;

            SerializedProperty idProp = property.FindPropertyRelative("id");
            SerializedProperty typeProp = property.FindPropertyRelative("_type");
            SerializedProperty comparisonProp = property.FindPropertyRelative("_comparison");
            SerializedProperty subjectProp = property.FindPropertyRelative("_subject");
            SerializedProperty targetProp = property.FindPropertyRelative("_target");

            float height = 0;
            height += EditorGUIUtility.singleLineHeight + 2; // foldout
            height += EditorGUI.GetPropertyHeight(idProp) + 2; // id 
            height += EditorGUIUtility.singleLineHeight + 2; // type
            height += EditorGUIUtility.singleLineHeight + 2; // comparison
            height += EditorGUI.GetPropertyHeight(subjectProp) + 2; // subject
            height += EditorGUI.GetPropertyHeight(targetProp) + 2; // target
            
            return height;
        }
    }
}