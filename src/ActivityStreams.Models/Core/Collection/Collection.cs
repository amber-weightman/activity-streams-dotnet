﻿using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ActivityStreams.Models.Core.Collection;

/// <inheritdoc cref="ICollection" />
public record Collection : Object, ICollection
{
    /// <inheritdoc cref="ICoreType.Type" />
    public override IAnyUri[]? Type { get; init; } = new[] { new AnyUri(ObjectType.Collection) };

    /// <inheritdoc cref="ICollection.TotalItems" />
    [Range(0, int.MaxValue)]
    public int? TotalItems { get; init; }

    /// <inheritdoc cref="ICollection.Current" />
    public ICoreType? Current { get; init; }

    /// <inheritdoc cref="ICollection.First" />
    public ICoreType? First { get; init; }

    /// <inheritdoc cref="ICollection.Last" />
    public ICoreType? Last { get; init; }

    /// <inheritdoc cref="ICollection.Items" />
    public ICoreType[]? Items { get; init; }
}