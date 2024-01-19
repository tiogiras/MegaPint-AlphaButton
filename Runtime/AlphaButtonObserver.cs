using System.Collections.Generic;
using com.tiogiras.megapint_alphabutton.Runtime;
using ValidationRequirement;

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
