using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;
using ValidationRequirement;

namespace com.tiogiras.megapint_alphabutton.Runtime
{

public class RequireAlphaButtons : ScriptableValidationRequirement
{
    protected override void OnInitialization() { }

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
}

}
