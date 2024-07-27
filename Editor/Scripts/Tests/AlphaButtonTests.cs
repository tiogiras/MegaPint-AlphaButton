#if UNITY_EDITOR
#if UNITY_INCLUDE_TESTS
using NUnit.Framework;
using UnityEngine;

namespace MegaPint.Editor.Scripts.Tests
{

/// <summary> Unit tests specific for the alphaButton package </summary>
internal class AlphaButtonTests
{
    #region Tests

    [Test]
    public void AddAsComponent()
    {
        var gameObject = new GameObject("AlphaButton Test");
        gameObject.AddComponent <AlphaButton>();
    }

    #endregion
}

}
#endif
#endif
