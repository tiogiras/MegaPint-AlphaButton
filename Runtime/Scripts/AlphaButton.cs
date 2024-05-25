using UnityEngine;
using UnityEngine.UI;

namespace MegaPint
{

/// <summary>
///     Component derived from the <see cref="Button" /> component that gives access ti the internal
///     <see cref="Image.alphaHitTestMinimumThreshold" />
/// </summary>
public class AlphaButton : Button
{
    [Tooltip("Alpha threshold for interacting with the button")]
    [SerializeField] [Range(0f, 1f)] private float _alphaThreshold = .5f;

    #region Unity Event Functions

    protected override void Awake()
    {
        base.Awake();

        if (targetGraphic is not Image castedImage)
            return;

        castedImage.alphaHitTestMinimumThreshold = _alphaThreshold;
    }

    #endregion
}

}
