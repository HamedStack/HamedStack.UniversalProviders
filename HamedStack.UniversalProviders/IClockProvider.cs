// ReSharper disable UnusedMember.Global

namespace HamedStack.UniversalProviders;

/// <summary>
/// Defines methods and properties to provide current date and time.
/// </summary>
public interface IClockProvider
{
    /// <summary>
    /// Gets the current local date and time.
    /// </summary>
    DateTime Now { get; }

    /// <summary>
    /// Gets the current local date and time, including the offset from UTC.
    /// </summary>
    DateTimeOffset OffsetNow { get; }

    /// <summary>
    /// Gets the current date and time as Coordinated Universal Time (UTC), including the offset.
    /// </summary>
    DateTimeOffset OffsetUtcNow { get; }

    /// <summary>
    /// Gets the current date and time as Coordinated Universal Time (UTC).
    /// </summary>
    DateTime UtcNow { get; }
}