#if UNITY_EDITOR
using UnityEngine.UIElements;

namespace Editor.Scripts
{

internal static partial class DisplayContent
{
    private const string BasePathAlphaButton = "Alpha Button/User Interface/Display Content Tabs/";

    #region Private Methods

    // Called by reflection
    // ReSharper disable once UnusedMember.Local
    private static void AlphaButton(VisualElement root)
    {
        var tabs = root.Q <GroupBox>("Tabs");
        var tabContentParent = root.Q <GroupBox>("TabContent");

        RegisterTabCallbacks(tabs, tabContentParent, 1);

        SetTabContentLocations(BasePathAlphaButton + "Tab0");

        s_onSelectedTabChanged += OnTabChangedAlphaButton;
        s_onSelectedPackageChanged += UnsubscribeAlphaButton;

        SwitchTab(tabContentParent, 0);
    }

    private static void OnTabChangedAlphaButton(int tab, VisualElement root)
    {
        switch (tab)
        {

        }
    }

    private static void UnsubscribeAlphaButton()
    {
        s_onSelectedTabChanged -= OnTabChangedAlphaButton;
        s_onSelectedPackageChanged -= UnsubscribeAlphaButton;
    }

    #endregion
}

}
#endif
