#if UNITY_EDITOR
using UnityEditor;

namespace Editor.Scripts
{

[CustomEditor(typeof(AlphaButtonObserver))]
public class AlphaButtonObserverDrawer : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Observing all AlphaButton components.");
    }
}

}
#endif
