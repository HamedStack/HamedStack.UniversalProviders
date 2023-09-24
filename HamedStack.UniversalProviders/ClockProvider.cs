// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace HamedStack.UniversalProviders;

/// <summary>
/// Represents a clock to provide current date and time.
/// </summary>
public class ClockProvider : IClockProvider
{
    /// <summary>
    /// Gets the current local date and time.
    /// </summary>
    /// <value>The current local date and time.</value>
    public DateTime Now => DateTime.Now;

    /// <summary>
    /// Gets the current date and time as Coordinated Universal Time (UTC).
    /// </summary>
    /// <value>The current UTC date and time.</value>
    public DateTime UtcNow => DateTime.UtcNow;

    /// <summary>
    /// Gets the current local date and time, including the offset from UTC.
    /// </summary>
    /// <value>The current local date and time with its offset from UTC.</value>
    public DateTimeOffset OffsetNow => DateTimeOffset.Now;

    /// <summary>
    /// Gets the current date and time as Coordinated Universal Time (UTC), including the offset.
    /// </summary>
    /// <value>The current UTC date and time with its offset.</value>
    public DateTimeOffset OffsetUtcNow => DateTimeOffset.UtcNow;
}