using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// Represents a document of any kind.
/// <a href="https://www.w3.org/ns/activitystreams#Document">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Document",
///   "name": "4Q Sales Forecast",
///   "url": "http://example.org/4q-sales-forecast.pdf"
/// }
/// </code>
/// </example>
public interface IDocument : IObject, ICoreType
{
}
