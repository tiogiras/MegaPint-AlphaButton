using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaPint.ValidationRequirement;
using UnityEngine;

[assembly: InternalsVisibleTo("tiogiras.megapint.editor")]

namespace MegaPint.com.tiogiras.megapint_alphabutton.Runtime.Scripts
{

/// <summary> Observes all <see cref="AlphaButton" /> components on this gameObject and adds validation requirements </summary>
[AddComponentMenu("")]
internal class AlphaButtonObserver : ValidatableMonoBehaviour
{
    private readonly List <ScriptableValidationRequirement> _customRequirements = new() {new RequireAlphaButtons()};

    #region Protected Methods

    protected override void BeforeValidation()
    {
        SetRequirements(_customRequirements);
    }

    #endregion
}

}
