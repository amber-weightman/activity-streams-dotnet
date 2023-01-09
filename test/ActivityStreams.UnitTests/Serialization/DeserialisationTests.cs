using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Core;
using ActivityStreams.Models.Core.Activity;
using ActivityStreams.Models.Core.Collection;
using ActivityStreams.Models.Extended.Activity;
using ActivityStreams.Models.Extended.Actor;
using ActivityStreams.Models.Extended.Object;
using ActivityStreams.Models.Utilities.Serialization;
using ActivityStreams.UnitTests.Utils;
using FluentAssertions;
using System.Text.Json;

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
        var sut = await JsonSerializer.DeserializeAsync<Accept>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Accept>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Accept);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Activity_0")]
    public async Task GivenValidActivityJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Activity>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Activity>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Activity);
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
        var sut = await JsonSerializer.DeserializeAsync<Add>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Add>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Add);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Announce_0")]
    public async Task GivenValidAnnounceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Announce>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Announce>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Announce);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Application_0")]
    public async Task GivenValidApplicationJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Application>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Application>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Application);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Arrive_0")]
    public async Task GivenValidArriveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Arrive>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Arrive>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Arrive);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Article_0")]
    public async Task GivenValidArticleJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Article>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Article>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Article);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Audio_0")]
    public async Task GivenValidAudioJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Audio>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Audio>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Audio);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Block_0")]
    public async Task GivenValidBlockJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Block>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Block>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Block);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Collection_0")]
    public async Task GivenValidCollectionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Collection>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Collection>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Collection);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("CollectionPage_0")]
    public async Task GivenValidCollectionPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<CollectionPage>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<CollectionPage>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.CollectionPage);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Create_0")]
    public async Task GivenValidCreateJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Create>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Create>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Create);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Delete_0")]
    public async Task GivenValidDeleteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Delete>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Delete>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Delete);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Dislike_0")]
    public async Task GivenValidDislikeJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Dislike>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Dislike>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Dislike);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Document_0")]
    public async Task GivenValidDocumentJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Document>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Document>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Document);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Event_0")]
    public async Task GivenValidEventJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Event>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Event>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Event);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Flag_0")]
    public async Task GivenValidFlagJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Flag>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Flag>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Flag);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Follow_0")]
    public async Task GivenValidFollowJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Follow>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Follow>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Follow);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Group_0")]
    public async Task GivenValidGroupJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Group>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Group>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Group);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Ignore_0")]
    public async Task GivenValidIgnoreJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Ignore>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Ignore>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Ignore);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Image_0")]
    public async Task GivenValidImageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Image>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Image>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Image);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Invite_0")]
    public async Task GivenValidInviteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Invite>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Invite>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Invite);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Join_0")]
    public async Task GivenValidJoinJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Join>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Join>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Join);
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
        var sut = await JsonSerializer.DeserializeAsync<Leave>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Leave>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Leave);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Like_0")]
    public async Task GivenValidLikeJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Like>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Like>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Like);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Link_0")]
    public async Task GivenValidLinkJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Link>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Link>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Link);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Listen_0")]
    public async Task GivenValidListenJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Listen>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Listen>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Listen);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Mention_0")]
    public async Task GivenValidMentionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Mention>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Mention>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Mention);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Move_0")]
    public async Task GivenValidMoveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Move>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Move>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Move);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Note_0")]
    public async Task GivenValidNoteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Note>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Note>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Note);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Object_0")]
    public async Task GivenValidObjectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Models.Core.Object>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Models.Core.Object>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Object);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Offer_0")]
    public async Task GivenValidOfferJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Offer>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Offer>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Offer);
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
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollection>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<OrderedCollection>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.OrderedCollection);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("OrderedCollectionPage_0")]
    public async Task GivenValidOrderedCollectionPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollectionPage>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<OrderedCollectionPage>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.OrderedCollectionPage);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Organization_0")]
    public async Task GivenValidOrganizationJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Organization>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Organization>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Organization);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Page_0")]
    public async Task GivenValidPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Page>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Page>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Page);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Person_0")]
    public async Task GivenValidPersonJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Person>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Person>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Person);
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
        var sut = await JsonSerializer.DeserializeAsync<Place>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Place>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Place);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Profile_0")]
    public async Task GivenValidProfileJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Profile>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Profile>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Profile);
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
        var sut = await JsonSerializer.DeserializeAsync<Question>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Question>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Question);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Read_0")]
    public async Task GivenValidReadJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Read>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Read>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Read);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Reject_0")]
    public async Task GivenValidRejectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Reject>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Reject>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Reject);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Relationship_0")]
    public async Task GivenValidRelationshipJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Relationship>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Relationship>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Relationship);
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
        var sut = await JsonSerializer.DeserializeAsync<Remove>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Remove>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Remove);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Service_0")]
    public async Task GivenValidServiceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Service>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Service>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Service);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("TentativeAccept_0")]
    public async Task GivenValidTentativeAcceptJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<TentativeAccept>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<TentativeAccept>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.TentativeAccept);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("TentativeReject_0")]
    public async Task GivenValidTentativeRejectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<TentativeReject>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<TentativeReject>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.TentativeReject);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Tombstone_0")]
    public async Task GivenValidTombstoneJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Tombstone>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Tombstone>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Tombstone);
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
        var sut = await JsonSerializer.DeserializeAsync<Travel>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Travel>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Travel);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Undo_0")]
    public async Task GivenValidUndoJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Undo>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Undo>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Undo);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Update_0")]
    public async Task GivenValidUpdateJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Update>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Update>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Update);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("Video_0")]
    public async Task GivenValidVideoJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Video>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<Video>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.Video);
        sut.Context.Should().NotBeEmpty();
    }

    [Theory]
    [InlineData("View_0")]
    public async Task GivenValidViewJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", "Serialization\\TestData"));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<View>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().NotBeNull().And.BeOfType<View>();
        sut!.Type.Should().ContainSingle().Which.Should().Be(ObjectType.View);
        sut.Context.Should().NotBeEmpty();
    }
}