#if UNITY_EDITOR
using Editor.Scripts.PackageManager.Cache;
using Editor.Scripts.PackageManager.Packages;
using Editor.Scripts.Windows;
using UnityEngine.UIElements;
using GUIUtility = Editor.Scripts.GUI.GUIUtility;

namespace Editor.Scripts
{

internal static partial class DisplayContent
{
    #region Private Methods

    // Called by reflection
    // ReSharper disable once UnusedMember.Local
    private static void AlphaButton(DisplayContentReferences refs)
    {
        VisualElement root = InitializeDisplayContent(refs);

        root.Q <Label>("PackageInfo").text = PackageCache.Get(PackageKey.AlphaButton).Description;
        
        GUIUtility.ActivateLinks(root,
                                 evt =>
                                 {
                                     switch (evt.linkID)
                                     {
                                         case "integration":
                                             MegaPintPackageManagerWindow.OpenPerLink(PackageKey.AlphaButton);
                                             break;
                                     }
                                 });
    }
    

    #endregion
}

}
#endif
