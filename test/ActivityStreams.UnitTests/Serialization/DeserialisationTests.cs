using ActivityStreams.Models.Extended.Activity;
using ActivityStreams.UnitTests.Utils;
using System.Text.Json;
using FluentAssertions;
using ActivityStreams.Models.Core.Activity;
using ActivityStreams.Contract.Core.Activity;
using ActivityStreams.Contract.Extended.Activity;
using ActivityStreams.Contract.Extended.Actor;
using ActivityStreams.Contract.Extended.Object;
using ActivityStreams.Models.Core.Collection;
using ActivityStreams.Models.Extended.Actor;
using ActivityStreams.Models.Extended.Object;
using ActivityStreams.Contract.Core.Collection;
using ActivityStreams.Contract.Core;
using ActivityStreams.Models.Core;

namespace ActivityStreams.UnitTests.Serialization;

public class DeserialisationTests
{
    [Theory]
    [InlineData("Accept_0")]
    [InlineData("Accept_1")]
    public async Task GivenValidAcceptJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));
        
        // Act
        var sut = await JsonSerializer.DeserializeAsync<Accept>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IAccept>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Activity_0")]
    public async Task GivenValidActivityJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Activity>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IActivity>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Add_0")]
    [InlineData("Add_1")]
    public async Task GivenValidAddJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Add>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IAdd>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Announce_0")]
    public async Task GivenValidAnnounceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Announce>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IAnnounce>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Application_0")]
    public async Task GivenValidApplicationJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Application>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IApplication>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Arrive_0")]
    public async Task GivenValidArriveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Arrive>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IArrive>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Article_0")]
    public async Task GivenValidArticleJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Article>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IArticle>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Audio_0")]
    public async Task GivenValidAudioJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Audio>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IAudio>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Block_0")]
    public async Task GivenValidBlockJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Block>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IBlock>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Collection_0")]
    public async Task GivenValidCollectionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Collection>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ICollection>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("CollectionPage_0")]
    public async Task GivenValidCollectionPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<CollectionPage>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ICollectionPage>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Create_0")]
    public async Task GivenValidCreateJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Create>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ICreate>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Delete_0")]
    public async Task GivenValidDeleteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Delete>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IDelete>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Dislike_0")]
    public async Task GivenValidDislikeJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Dislike>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IDislike>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Document_0")]
    public async Task GivenValidDocumentJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Document>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IDocument>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Event_0")]
    public async Task GivenValidEventJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Event>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IEvent>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Flag_0")]
    public async Task GivenValidFlagJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Flag>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IFlag>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Follow_0")]
    public async Task GivenValidFollowJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Follow>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IFollow>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Group_0")]
    public async Task GivenValidGroupJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Group>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IGroup>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Ignore_0")]
    public async Task GivenValidIgnoreJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Ignore>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IIgnore>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Image_0")]
    public async Task GivenValidImageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Image>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IImage>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("IntrasitiveActivity_0")]
    public async Task GivenValidIntrasitiveActivityJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<IntrasitiveActivity>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IIntrasitiveActivity>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Invite_0")]
    public async Task GivenValidInviteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Invite>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IInvite>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Join_0")]
    public async Task GivenValidJoinJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Join>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IJoin>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Leave_0")]
    [InlineData("Leave_1")]
    public async Task GivenValidLeaveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Leave>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ILeave>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Like_0")]
    public async Task GivenValidLikeJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Like>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ILike>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Link_0")]
    public async Task GivenValidLinkJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Link>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ILink>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Listen_0")]
    public async Task GivenValidListenJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Listen>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IListen>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Mention_0")]
    public async Task GivenValidMentionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Mention>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IMention>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Move_0")]
    public async Task GivenValidMoveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Move>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IMove>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Note_0")]
    public async Task GivenValidNoteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Note>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<INote>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Object_0")]
    public async Task GivenValidObjectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Models.Core.Object>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IObject>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Offer_0")]
    public async Task GivenValidOfferJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Offer>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IOffer>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("OrderedCollection_0")]
    [InlineData("OrderedCollection_1")]
    public async Task GivenValidOrderedCollectionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollection>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IOrderedCollection>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("OrderedCollectionPage_0")]
    public async Task GivenValidOrderedCollectionPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollectionPage>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IOrderedCollectionPage>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Organization_0")]
    public async Task GivenValidOrganizationJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Organization>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IOrganization>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Page_0")]
    public async Task GivenValidPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Page>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IPage>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Person_0")]
    public async Task GivenValidPersonJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Person>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IPerson>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Place_0")]
    [InlineData("Place_1")]
    public async Task GivenValidPlaceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Place>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IPlace>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Profile_0")]
    public async Task GivenValidProfileJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Profile>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IProfile>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Question_0")]
    [InlineData("Question_1")]
    public async Task GivenValidQuestionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Question>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IQuestion>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Read_0")]
    public async Task GivenValidReadJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Read>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IRead>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Reject_0")]
    public async Task GivenValidRejectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Reject>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IReject>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Relationship_0")]
    public async Task GivenValidRelationshipJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Relationship>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IRelationship>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Remove_0")]
    [InlineData("Remove_1")]
    public async Task GivenValidRemoveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Remove>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IRemove>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Service_0")]
    public async Task GivenValidServiceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Service>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IService>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("TentativeAccept_0")]
    public async Task GivenValidTentativeAcceptJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<TentativeAccept>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ITentativeAccept>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("TentativeReject_0")]
    public async Task GivenValidTentativeRejectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<TentativeReject>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ITentativeReject>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Tombstone_0")]
    public async Task GivenValidTombstoneJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Tombstone>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ITombstone>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Travel_0")]
    [InlineData("Travel_1")]
    public async Task GivenValidTravelJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Travel>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<ITravel>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Undo_0")]
    public async Task GivenValidUndoJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Undo>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IUndo>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Update_0")]
    public async Task GivenValidUpdateJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Update>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IUpdate>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Video_0")]
    public async Task GivenValidVideoJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Video>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IVideo>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("View_0")]
    public async Task GivenValidViewJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<View>(reader.BaseStream);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<IView>();
        sut.Type.Should().NotBeEmpty();
        sut.Context.Should().NotBeEmpty();
    }
}