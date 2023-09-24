// ReSharper disable UnusedMember.Global

namespace HamedStack.UniversalProviders;

/// <summary>
/// Defines a method to generate new GUID values.
/// </summary>
public interface IGuidProvider
{
    /// <summary>
    /// Generates a new GUID.
    /// </summary>
    /// <returns>A new unique GUID.</returns>
    Guid NewGuid();
}