using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Core;
using ActivityStreams.Models.Core.Activity;
using ActivityStreams.Models.Core.Collection;
using ActivityStreams.Models.Extended.Activity;
using ActivityStreams.Models.Extended.Actor;
using ActivityStreams.Models.Extended.Object;

namespace ActivityStreams.Models.Utilities.Extensions;

/// <summary>
/// <see cref="ObjectType"/> extensions
/// </summary>
public static class TypeExtensions
{
    /// <summary>
    /// Converter to map from <see cref="ObjectType"/> to <see cref="Type"/>.
    /// Returned <c>Type</c> should be for an implementation of <see cref="ICoreType"/>, however this is not currently enforced.
    /// </summary>
    public static Type ToType(this ObjectType objectType)
    {
        switch(objectType)
        {
            case ObjectType.Unknown:
                throw new ArgumentException($"{nameof(ObjectType)} not supported");
            case ObjectType.Object:
                return typeof(Core.Object);
            case ObjectType.Article:
                return typeof(Article);
            case ObjectType.Audio:
                return typeof(Audio);
            case ObjectType.Document:
                return typeof(Document);
            case ObjectType.Event:
                return typeof(Event);
            case ObjectType.Image:
                return typeof(Image);
            case ObjectType.Note:
                return typeof(Note);
            case ObjectType.Page:
                return typeof(Page);
            case ObjectType.Place:
                return typeof(Place);
            case ObjectType.Profile:
                return typeof(Profile);
            case ObjectType.Relationship:
                return typeof(Relationship);
            case ObjectType.Tombstone:
                return typeof(Tombstone);
            case ObjectType.Video:
                return typeof(Video);
            case ObjectType.Collection:
                return typeof(Collection);
            case ObjectType.CollectionPage:
                return typeof(CollectionPage);
            case ObjectType.OrderedCollection:
                return typeof(OrderedCollection);
            case ObjectType.OrderedCollectionPage:
                return typeof(OrderedCollectionPage);
            case ObjectType.Link:
                return typeof(Link);
            case ObjectType.Mention:
                return typeof(Mention);
            case ObjectType.Actor:
                return typeof(Core.Object); // "this shouldn't happen" :P
            case ObjectType.Application:
                return typeof(Application);
            case ObjectType.Group:
                return typeof(Group);
            case ObjectType.Organization:
                return typeof(Organization);
            case ObjectType.Person:
                return typeof(Person);
            case ObjectType.Service:
                return typeof(Service);
            case ObjectType.Activity:
                return typeof(Activity);
            case ObjectType.IntrasitiveActivity:
                return typeof(IntrasitiveActivity);
            case ObjectType.Accept:
                return typeof(Accept);
            case ObjectType.Add:
                return typeof(Add);
            case ObjectType.Announce:
                return typeof(Announce);
            case ObjectType.Arrive:
                return typeof(Arrive);
            case ObjectType.Block:
                return typeof(Block);
            case ObjectType.Create:
                return typeof(Create);
            case ObjectType.Delete:
                return typeof(Delete);
            case ObjectType.Dislike:
                return typeof(Dislike);
            case ObjectType.Flag:
                return typeof(Flag);
            case ObjectType.Follow:
                return typeof(Follow);
            case ObjectType.Ignore:
                return typeof(Ignore);
            case ObjectType.Invite:
                return typeof(Invite);
            case ObjectType.Join:
                return typeof(Join);
            case ObjectType.Leave:
                return typeof(Leave);
            case ObjectType.Like:
                return typeof(Like);
            case ObjectType.Listen:
                return typeof(Listen);
            case ObjectType.Move:
                return typeof(Move);
            case ObjectType.Offer:
                return typeof(Offer);
            case ObjectType.Question:
                return typeof(Question);
            case ObjectType.Reject:
                return typeof(Reject);
            case ObjectType.Read:
                return typeof(Read);
            case ObjectType.Remove:
                return typeof(Remove);
            case ObjectType.TentativeReject:
                return typeof(TentativeReject);
            case ObjectType.TentativeAccept:
                return typeof(TentativeAccept);
            case ObjectType.Travel:
                return typeof(Travel);
            case ObjectType.Undo:
                return typeof(Undo);
            case ObjectType.Update:
                return typeof(Update);
            case ObjectType.View:
                return typeof(View);
            default:
                throw new ArgumentException($"{nameof(ObjectType)} not supported");

        }
    }
}
