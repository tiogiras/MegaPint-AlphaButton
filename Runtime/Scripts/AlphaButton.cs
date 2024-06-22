using UnityEngine;
using UnityEngine.UI;

namespace MegaPint.com.tiogiras.megapint_alphabutton.Runtime.Scripts
{

/// <summary>
///     Component derived from the <see cref="Button" /> component that gives access ti the internal
///     <see cref="Image.alphaHitTestMinimumThreshold" />
/// </summary>
[RequireComponent(typeof(AlphaButtonObserver))]
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

    #region Public Methods

    /// <summary> Set the alphaThreshold of the button </summary>
    /// <param name="alphaThreshold"> New threshold </param>
    public void SetAlphaThreshold(float alphaThreshold)
    {
        _alphaThreshold = alphaThreshold;

        if (targetGraphic is not Image castedImage)
            return;
        
        castedImage.alphaHitTestMinimumThreshold = _alphaThreshold;
    }

    #endregion
}

}
