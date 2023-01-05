using ActivityStreams.Contract.Core;

namespace ActivityStreams.Models.Core.Types;

/// <inheritdoc cref="IIntrasitiveActivity" />
public record IntrasitiveActivity : ActivityBase, IIntrasitiveActivity, IActivityBase, IObject, ICoreType
{
}