using System.Collections.Generic;
using ValidationRequirement;

namespace MegaPint.com.tiogiras.megapint_alphabutton.Runtime.Scripts
{

/// <summary> Observes all <see cref="AlphaButton" /> components on this gameObject and adds validation requirements </summary>
public class AlphaButtonObserver : ValidatableMonoBehaviour
{
    private readonly List <IValidationRequirement> _customRequirements = new() {new RequireAlphaButtons()};

    #region Protected Methods

    protected override void BeforeValidation()
    {
        SetRequirements(_customRequirements);
    }

    #endregion
}

}
