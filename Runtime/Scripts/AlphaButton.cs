using UnityEngine;
using UnityEngine.UI;

namespace MegaPint.com.tiogiras.megapint_alphabutton.Runtime.Scripts
{

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
}

}
