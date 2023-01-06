using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Activity;

namespace ActivityStreams.Models.Core.Activity;

/// <inheritdoc cref="IIntrasitiveActivity" />
public record IntrasitiveActivity : ActivityBase, IIntrasitiveActivity, IActivityBase, IObject, ICoreType
{
    /// <summary>
    /// Constructor for <see cref="IntrasitiveActivity"/>
    /// </summary>
    public IntrasitiveActivity(ICoreType[] context) : base(context)
    {
    }

    /// <summary>
    /// Constructor for <see cref="IntrasitiveActivity"/>
    /// </summary>
    public IntrasitiveActivity(ICoreType context) : base(context)
    {
    }
}