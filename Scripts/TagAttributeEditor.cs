using UnityEditor;
using UnityEngine;

namespace UnityEditorExtensions
{
    [CustomPropertyDrawer(typeof(TagAttribute))]
    class TagAttributeEditor : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            property.stringValue = EditorGUI.TagField(position, label, property.stringValue);
        }
    }
}