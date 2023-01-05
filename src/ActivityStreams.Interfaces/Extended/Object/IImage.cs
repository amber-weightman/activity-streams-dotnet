using ActivityStreams.Contract.Core;

namespace ActivityStreams.Contract.Extended.Object;

/// <summary>
/// An image document of any kind
/// <a href="https://www.w3.org/ns/activitystreams#Image">See w3.org for further details.</a>
/// </summary>
/// <example>
/// <code>
/// {
///   "@context": "https://www.w3.org/ns/activitystreams",
///   "type": "Image",
///   "name": "Cat Jumping on Wagon",
///   "url": [
///     {
///       "type": "Link",
///       "href": "http://example.org/image.jpeg",
///       "mediaType": "image/jpeg"
///     },
///     {
///     "type": "Link",
///       "href": "http://example.org/image.png",
///       "mediaType": "image/png"
///     }
///   ]
/// }
/// </code>
/// </example>
public interface IImage : IDocument, IObject, ICoreType
{
}
