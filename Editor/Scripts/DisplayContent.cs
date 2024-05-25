#if UNITY_EDITOR
using MegaPint.Editor.Scripts.GUI.Utility;
using MegaPint.Editor.Scripts.PackageManager.Cache;
using MegaPint.Editor.Scripts.PackageManager.Packages;
using UnityEngine.UIElements;

namespace MegaPint.Editor.Scripts
{

/// <summary> Partial class used to display the right pane in the BaseWindow </summary>
internal static partial class DisplayContent
{
    #region Private Methods

    // Called by reflection
    // ReSharper disable once UnusedMember.Local
    private static void AlphaButton(DisplayContentReferences refs)
    {
        VisualElement root = InitializeDisplayContent(refs);

        root.Q <Label>("PackageInfo").text = PackageCache.Get(PackageKey.AlphaButton).Description;

        root.ActivateLinks(
            evt =>
            {
                switch (evt.linkID)
                {
                    case "integration":
                        Windows.PackageManager.OpenPerLink(PackageKey.AlphaButton);

                        break;
                }
            });
    }

    #endregion
}

}
#endif
