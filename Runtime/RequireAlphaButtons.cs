using MegaPint.com.tiogiras.megapint_alphabutton.Runtime.Scripts;
using UnityEngine;
using UnityEngine.UI;
using ValidationRequirement;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace com.tiogiras.megapint_alphabutton.Runtime
{

public class RequireAlphaButtons : ScriptableValidationRequirement
{
    #region Protected Methods

    protected override void OnInitialization()
    {
    }

    protected override void Validate(GameObject gameObject)
    {
        AlphaButton[] buttons = gameObject.GetComponents <AlphaButton>();

        var incorrectButtons = 0;

        foreach (AlphaButton button in buttons)
        {
            if (button.targetGraphic is not Image castedImage)
                continue;

            if (!castedImage.sprite.texture.isReadable)
                incorrectButtons++;
        }

        if (incorrectButtons <= 0)
            return;

        var str = incorrectButtons > 1 ? "s" : "";
        var str1 = incorrectButtons > 1 ? "are" : "is";

        AddError(
            $"Texture{str} not readable",
            $"Sprite texture{str} of {incorrectButtons} button{str} {str1} not readable",
            ValidationState.Error,
            FixAction);
    }

    #endregion

    #region Private Methods

    private void FixAction(GameObject gameObject)
    {
#if UNITY_EDITOR
        AlphaButton[] buttons = gameObject.GetComponents <AlphaButton>();

        foreach (AlphaButton button in buttons)
        {
            if (button.targetGraphic is not Image castedImage)
                continue;

            if (castedImage.sprite.texture.isReadable)
                continue;

            var path = AssetDatabase.GetAssetPath(castedImage.sprite.texture);
            var importer = (TextureImporter)AssetImporter.GetAtPath(path);

            importer.isReadable = true;
            importer.SaveAndReimport();
        }
#endif
    }

    #endregion
}

}
