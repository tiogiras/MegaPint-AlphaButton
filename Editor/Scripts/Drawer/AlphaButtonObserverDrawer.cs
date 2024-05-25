#if UNITY_EDITOR
using UnityEditor;

namespace MegaPint.Editor.Scripts.Drawer
{

/// <summary> Drawer class for the <see cref="AlphaButtonObserver" /> component </summary>
[CustomEditor(typeof(AlphaButtonObserver))]
public class AlphaButtonObserverDrawer : UnityEditor.Editor
{
    #region Public Methods

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Observing all AlphaButton components.");
    }

    #endregion
}

}
#endif
