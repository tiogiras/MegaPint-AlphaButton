#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UI;

namespace MegaPint.Editor.Scripts.Drawer
{

/// <summary> Drawer class for the <see cref="AlphaButton" /> component </summary>
[CustomEditor(typeof(AlphaButton))]
public class AlphaButtonDrawer : ButtonEditor
{
    #region Public Methods

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Alpha Settings", EditorStyles.boldLabel);

        SerializedProperty threshold = serializedObject.FindProperty("_alphaThreshold");
        EditorGUILayout.PropertyField(threshold);

        serializedObject.ApplyModifiedProperties();

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Button Settings", EditorStyles.boldLabel);

        base.OnInspectorGUI();
    }

    #endregion
}

}
#endif
