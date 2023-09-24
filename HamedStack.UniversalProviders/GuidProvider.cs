// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace HamedStack.UniversalProviders;

/// <summary>
/// Generates new GUID values.
/// </summary>
public class GuidProvider : IGuidProvider
{
    /// <summary>
    /// Generates a new GUID.
    /// </summary>
    /// <returns>A new unique GUID.</returns>
    public Guid NewGuid()
    {
        return Guid.NewGuid();
    }
}