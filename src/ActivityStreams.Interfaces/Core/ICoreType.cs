using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActivityStreams.Contract.Core;

public interface ICoreType
{
    /// <summary>
    /// Identifies the context within which the object exists or an 
    /// activity was performed.<br/>
    /// The notion of "context" used is intentionally vague.The intended
    /// function is to serve as a means of grouping objects and 
    /// activities that share a common originating context or purpose.
    /// An example could be all activities relating to a common project 
    /// or event.
    /// Must be either <see cref="IObject"/> or <see cref="ILink"/>.
    /// <a href="https://www.w3.org/ns/activitystreams#context">See w3.org for further details.</a>
    /// </summary>
    [JsonProperty("@context")]
    ICoreType[] Context { get; }

    abstract Enum? Type { get; }
}
