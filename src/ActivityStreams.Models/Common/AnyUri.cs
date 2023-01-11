using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Types;

namespace ActivityStreams.Models.Common;

/// <inheritdoc cref="IAnyUri" />
public record AnyUri : IAnyUri
{
    /// <summary>
    /// Constructor for <see cref="AnyUri"/>
    /// </summary>
    public AnyUri()
    {
    }

    /// <summary>
    /// Constructor for <see cref="AnyUri"/>
    /// </summary>
    public AnyUri(string type)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            throw new ArgumentNullException(nameof(type));
        }
        if (Uri.TryCreate(type, new(), out Uri? result))
        {
            Href = result;
        }
        if (Enum.TryParse(type, out ObjectType objectType))
        {
            Type = objectType;
        }
    }

    /// <summary>
    /// Constructor for <see cref="AnyUri"/>
    /// </summary>
    public AnyUri(ObjectType type)
    {
        if (Uri.TryCreate(type.ToString(), new(), out Uri? result))
        {
            Href = result;
        }
        Type = type;
    }

    /// <summary>
    /// Constructor for <see cref="AnyUri"/>
    /// </summary>
    public AnyUri(Uri type)
    {
        Href = type;
        if (Enum.TryParse(type.ToString(), out ObjectType objectType))
        {
            Type = objectType;
        }
    }

    /// <inheritdoc cref="IAnyUri.Type" />
    public ObjectType? Type { get; init; }

    /// <inheritdoc cref="IAnyUri.Href" />
    public Uri Href { get; init; } = null!;

    /// <inheritdoc />
    public override string ToString()
    {
        if (Href is not null)
        {
            return Href.ToString();
        }
        else if (Type is not null)
        {
            return Type.Value.ToString() ?? base.ToString() ?? nameof(AnyUri);
        }
        return base.ToString() ?? nameof(AnyUri);
    }
}
