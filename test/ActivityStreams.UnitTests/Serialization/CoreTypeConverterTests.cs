using ActivityStreams.Contract.Common;
using ActivityStreams.Contract.Core;
using ActivityStreams.Contract.Types;
using ActivityStreams.Models.Common;
using ActivityStreams.Models.Core;
using ActivityStreams.Models.Core.Activity;
using ActivityStreams.Models.Core.Collection;
using ActivityStreams.Models.Extended.Activity;
using ActivityStreams.Models.Extended.Actor;
using ActivityStreams.Models.Extended.Object;
using ActivityStreams.Models.Utilities.Helpers;
using ActivityStreams.Models.Utilities.Serialization;
using ActivityStreams.UnitTests.Utils;
using FluentAssertions;
using System.Text.Json;
using Object = ActivityStreams.Models.Core.Object;

namespace ActivityStreams.UnitTests.Serialization;

public class CoreTypeConverterTests
{
    private const string FilePath = "Serialization\\TestData";

    [Theory]
    [InlineData("Accept_0")]
    public async Task GivenValidAcceptJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Accept>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Accept
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally accepted an invitation to a party" },
            Type = new[] { new AnyUri(ObjectType.Accept) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Invite
                {
                    Type = new[] { new AnyUri(ObjectType.Invite) },
                    Actor = new []
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://john.example.org"),
                        }
                    },
                    Object = new []
                    {
                        new Event
                        {
                            Type = new[] { new AnyUri(ObjectType.Event) },
                            Name = new RdfLangString { String = "Going-Away Party for Jim" }
                        }
                    }
                }
            }
        });
    }

    [Theory]
    [InlineData("Accept_1")]
    public async Task GivenValidAcceptJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Accept>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Accept
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally accepted Joe into the club" },
            Type = new[] { new AnyUri(ObjectType.Accept) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Joe" },
                }
            },
            Target = new[]
            {
                new Group
                {
                    Type = new[] { new AnyUri(ObjectType.Group) },
                    Name = new RdfLangString { String = "The Club" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Activity_0")]
    public async Task GivenValidActivityJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Activity>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Activity
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally did something to a note" },
            Type = new[] { new AnyUri(ObjectType.Activity) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "A Note" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Add_0")]
    public async Task GivenValidAddJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Add>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Add
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally added an object" },
            Type = new[] { new AnyUri(ObjectType.Add) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/abc")
                }
            }
        });
    }

    [Theory]
    [InlineData("Add_1")]
    public async Task GivenValidAddJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Add>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Add
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally added a picture of her cat to her cat picture collection" },
            Type = new[] { new AnyUri(ObjectType.Add) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Image
                {
                    Type = new[] { new AnyUri(ObjectType.Image) },
                    Name = new RdfLangString { String = "A picture of my cat" },
                    Url = new []
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://example.org/img/cat.png")
                        }
                    }
                }
            },
            Origin = new[] 
            {
                new Collection
                {
                    Type = new[] { new AnyUri(ObjectType.Collection) },
                    Name = new RdfLangString { String = "Camera Roll" },
                }
            },
            Target = new[]
            {
                new Collection
                {
                    Type = new[] { new AnyUri(ObjectType.Collection) },
                    Name = new RdfLangString { String = "My Cat Pictures" },
                }
            }
        });
    }


    [Theory]
    [InlineData("Announce_0")]
    public async Task GivenValidAnnounceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Announce>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Announce
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally announced that she had arrived at work" },
            Type = new[] { new AnyUri(ObjectType.Announce) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                    Id = new Uri("http://sally.example.org")
                }
            },
            Object = new[]
            {
                new Arrive
                {
                    Type = new[] { new AnyUri(ObjectType.Arrive) },
                    Actor = new[]
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://sally.example.org")
                        }
                    },
                    Location = new []
                    {
                        new Place
                        {
                            Type = new[] { new AnyUri(ObjectType.Place) },
                            Name = new RdfLangString { String = "Work" },
                        }
                    }
                }
            }
        });
    }

    [Theory]
    [InlineData("Application_0")]
    public async Task GivenValidApplicationJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Application>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Application
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Exampletron 3000" },
            Type = new[] { new AnyUri(ObjectType.Application) 
            }
        });
    }

    [Theory]
    [InlineData("Arrive_0")]
    public async Task GivenValidArriveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Arrive>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Arrive
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally arrived at work" },
            Type = new[] { new AnyUri(ObjectType.Arrive) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Location = new[]
            {
                new Place
                {
                    Type = new[] { new AnyUri(ObjectType.Place) },
                    Name = new RdfLangString { String = "Work" },
                }
            },
            Origin = new[]
            {
                new Place
                {
                    Type = new[] { new AnyUri(ObjectType.Place) },
                    Name = new RdfLangString { String = "Home" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Article_0")]
    public async Task GivenValidArticleJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Article>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Article
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "What a Crazy Day I Had" },
            Content = new RdfLangString { String = "<div>... you will never believe ...</div>" },
            Type = new[] { new AnyUri(ObjectType.Article) },
            AttributedTo = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://sally.example.org")
                }
            },
        });
    }

    [Theory]
    [InlineData("Audio_0")]
    public async Task GivenValidAudioJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Audio>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Audio
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Interview With A Famous Technologist" },
            Type = new[] { new AnyUri(ObjectType.Audio) },
            Url = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/podcast.mp3"),
                    MediaType = "audio/mp3"
                }
            },
        });
    }

    [Theory]
    [InlineData("Block_0")]
    public async Task GivenValidBlockJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Block>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Block
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally blocked Joe" },
            Type = new[] { new AnyUri(ObjectType.Block) },
            Actor = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://sally.example.org")
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://joe.example.org")
                }
            },
        });
    }

    [Theory]
    [InlineData("Collection_0")]
    public async Task GivenValidCollectionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Collection>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Collection
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally's notes" },
            Type = new[] { new AnyUri(ObjectType.Collection) },
            TotalItems = 2,
            Items = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "A Simple Note" },
                },
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "Another Simple Note" },
                }
            }
        });
    }

    [Theory]
    [InlineData("CollectionPage_0")]
    public async Task GivenValidCollectionPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<CollectionPage>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new CollectionPage
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Page 1 of Sally's notes" },
            Type = new[] { new AnyUri(ObjectType.CollectionPage) },
            Id = new Uri("http://example.org/foo?page=1"),
            PartOf = new Link
            {
                Type = new[] { new AnyUri(ObjectType.Link) },
                Href = new Uri("http://example.org/foo")
            },
            Items = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "A Simple Note" },
                },
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "Another Simple Note" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Create_0")]
    public async Task GivenValidCreateJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Create>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Create
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally created a note" },
            Type = new[] { new AnyUri(ObjectType.Create) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "A Simple Note" },
                    Content = new RdfLangString { String = "This is a simple note" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Delete_0")]
    public async Task GivenValidDeleteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Delete>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Delete
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally deleted a note" },
            Type = new[] { new AnyUri(ObjectType.Delete) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/notes/1")
                }
            },
            Origin = new[]
            {
                new Collection
                {
                    Type = new[] { new AnyUri(ObjectType.Collection) },
                    Name = new RdfLangString { String = "Sally's Notes" }
                }
            },
        });
    }

    [Theory]
    [InlineData("Dislike_0")]
    public async Task GivenValidDislikeJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Dislike>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Dislike
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally disliked a post" },
            Type = new[] { new AnyUri(ObjectType.Dislike) },
            Actor = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://sally.example.org")
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/posts/1")
                }
            }
        });
    }

    [Theory]
    [InlineData("Document_0")]
    public async Task GivenValidDocumentJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Document>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Document
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "4Q Sales Forecast" },
            Type = new[] { new AnyUri(ObjectType.Document) },
            Url = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/4q-sales-forecast.pdf")
                }
            }
        });
    }

    [Theory]
    [InlineData("Event_0")]
    public async Task GivenValidEventJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Event>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Event
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Going-Away Party for Jim" },
            Type = new[] { new AnyUri(ObjectType.Event) },
            StartTime = new DateTimeXsd("2014-12-31T23:00:00-08:00"),
            EndTime = new DateTimeXsd("2015-01-01T06:00:00-08:00")
        });
    }

    [Theory]
    [InlineData("Flag_0")]
    public async Task GivenValidFlagJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Flag>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Flag
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally flagged an inappropriate note" },
            Type = new[] { new AnyUri(ObjectType.Flag) },
            Actor = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://sally.example.org")
                }
            },
            Object = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Summary = new RdfLangString { String = "An inappropriate note" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Follow_0")]
    public async Task GivenValidFollowJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Follow>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Follow
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally followed John" },
            Type = new[] { new AnyUri(ObjectType.Follow) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "John" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Group_0")]
    public async Task GivenValidGroupJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Group>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Group
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Big Beards of Austin" },
            Type = new[] { new AnyUri(ObjectType.Group) }
        });
    }

    [Theory]
    [InlineData("Ignore_0")]
    public async Task GivenValidIgnoreJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Ignore>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Ignore
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally ignored a note" },
            Type = new[] { new AnyUri(ObjectType.Ignore) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/notes/1")
                }
            }
        });
    }

    [Theory]
    [InlineData("Image_0")]
    public async Task GivenValidImageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Image>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Image
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Cat Jumping on Wagon" },
            Type = new[] { new AnyUri(ObjectType.Image) },
            Url = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/image.jpeg"),
                    MediaType = "image/jpeg"
                },
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/image.png"),
                    MediaType = "image/png"
                }
            }
        });
    }

    [Theory]
    [InlineData("Invite_0")]
    public async Task GivenValidInviteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Invite>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Invite
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally invited John and Lisa to a party" },
            Type = new[] { new AnyUri(ObjectType.Invite) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Event
                {
                    Type = new[] { new AnyUri(ObjectType.Event) },
                    Name = new RdfLangString { String = "A Party" }
                }
            },
            Target = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "John" },
                },
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Lisa" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Join_0")]
    public async Task GivenValidJoinJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Join>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Join
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally joined a group" },
            Type = new[] { new AnyUri(ObjectType.Join) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Group
                {
                    Type = new[] { new AnyUri(ObjectType.Group) },
                    Name = new RdfLangString { String = "A Simple Group" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Leave_0")]
    public async Task GivenValidLeaveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Leave>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Leave
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally left work" },
            Type = new[] { new AnyUri(ObjectType.Leave) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Place
                {
                    Type = new[] { new AnyUri(ObjectType.Place) },
                    Name = new RdfLangString { String = "Work" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Leave_1")]
    public async Task GivenValidLeaveJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Leave>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Leave
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally left a group" },
            Type = new[] { new AnyUri(ObjectType.Leave) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Group
                {
                    Type = new[] { new AnyUri(ObjectType.Group) },
                    Name = new RdfLangString { String = "A Simple Group" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Like_0")]
    public async Task GivenValidLikeJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Like>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Like
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally liked a note" },
            Type = new[] { new AnyUri(ObjectType.Like) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/notes/1")
                }
            }
        });
    }

    [Theory]
    [InlineData("Link_0")]
    public async Task GivenValidLinkJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Link>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Link
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Type = new[] { new AnyUri(ObjectType.Link) },
            Href = new Uri("http://example.org/abc"),
            HrefLang = "en",
            MediaType = "text/html",
            Name = new RdfLangString { String = "An example link" },
        });
    }

    [Theory]
    [InlineData("Listen_0")]
    public async Task GivenValidListenJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Listen>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Listen
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally listened to a piece of music" },
            Type = new[] { new AnyUri(ObjectType.Listen) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/music.mp3")
                }
            }
        });
    }

    [Theory]
    [InlineData("Mention_0")]
    public async Task GivenValidMentionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Mention>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Mention
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            // Summary is in the W3 sample data, but that looks like a mistake - according to other info on that site Summary is valid for Objects only
            //Summary = new RdfLangString { String = "Mention of Joe by Carrie in her note" },
            Type = new[] { new AnyUri(ObjectType.Mention) },
            Href = new Uri("http://example.org/joe"),
            Name = new RdfLangString { String = "Joe" },
        });
    }

    [Theory]
    [InlineData("Move_0")]
    public async Task GivenValidMoveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Move>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Move
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally moved a post from List A to List B" },
            Type = new[] { new AnyUri(ObjectType.Move) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/posts/1")
                }
            },
            Target = new[]
            {
                new Collection
                {
                    Type = new[] { new AnyUri(ObjectType.Collection) },
                    Name = new RdfLangString { String = "List B" },
                }
            },
            Origin = new[]
            {
                new Collection
                {
                    Type = new[] { new AnyUri(ObjectType.Collection) },
                    Name = new RdfLangString { String = "List A" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Note_0")]
    public async Task GivenValidNoteJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Note>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Note
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Type = new[] { new AnyUri(ObjectType.Note) },
            Name = new RdfLangString { String = "A Word of Warning" },
            Content = new RdfLangString { String = "Looks like it is going to rain today. Bring an umbrella!" }
        });
    }

    [Theory]
    [InlineData("Object_0")]
    public async Task GivenValidObjectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Object>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Object
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Type = new[] { new AnyUri(ObjectType.Object) },
            Name = new RdfLangString { String = "A Simple, non-specific object" },
            Id = new Uri("http://www.test.example/object/1")
        });
    }

    [Theory]
    [InlineData("Offer_0")]
    public async Task GivenValidOfferJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Offer>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Offer
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally offered 50% off to Lewis" },
            Type = new[] { new AnyUri(ObjectType.Offer) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" },
                }
            },
            Object = new[]
            {
                new Object
                {
                    Type = new [] { new AnyUri("http://www.types.example/ProductOffer") },
                    Name = new RdfLangString { String = "50% Off!" },
                }
            },
            Target = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Lewis" }
                }
            }
        });
    }

    [Theory]
    [InlineData("OrderedCollection_0")]
    public async Task GivenValidOrderedCollectionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollection>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new OrderedCollection
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally's notes" },
            Type = new[] { new AnyUri(ObjectType.OrderedCollection) },
            TotalItems = 2,
            Items = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "A Simple Note" },
                },
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "Another Simple Note" },
                }
            }
        });
    }

    [Theory]
    [InlineData("OrderedCollection_1")]
    public async Task GivenValidOrderedCollectionJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollection>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new OrderedCollection
        {
            Name = new RdfLangString { String = "Vacation photos 2016" },
            Type = new[] { new AnyUri(ObjectType.OrderedCollection) },
            TotalItems = 3,
            Items = new ICoreType[]
            {
                new Image
                {
                    Type = new[] { new AnyUri(ObjectType.Image) },
                    Id = new Uri("http://image.example/1")
                },
                new Tombstone
                {
                    Type = new[] { new AnyUri(ObjectType.Tombstone) },
                    //FormerType = new[] { new AnyUri(ObjectType.Image) }, // TODO FIX
                    Id = new Uri("http://image.example/2"),
                    Deleted = new DateTimeXsd("2016-03-17T00:00:00Z")
                },
                new Image
                {
                    Type = new[] { new AnyUri(ObjectType.Image) },
                    Id = new Uri("http://image.example/3")
                }
            }
        });
    }

    [Theory]
    [InlineData("OrderedCollectionPage_0")]
    public async Task GivenValidOrderedCollectionPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollectionPage>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new OrderedCollectionPage
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Page 1 of Sally's notes" },
            Type = new[] { new AnyUri(ObjectType.OrderedCollectionPage) },
            Id = new Uri("http://example.org/foo?page=1"),
            PartOf = new Link
            {
                Type = new[] { new AnyUri(ObjectType.Link) },
                Href = new Uri("http://example.org/foo")
            },
            Items = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "A Simple Note" },
                },
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "Another Simple Note" },
                }
            }
        });
    }

    [Theory]
    [InlineData("Organization_0")]
    public async Task GivenValidOrganizationJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Organization>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Organization
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Example Co." },
            Type = new[] { new AnyUri(ObjectType.Organization) }
        });
    }

    [Theory]
    [InlineData("Page_0")]
    public async Task GivenValidPageJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Page>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Page
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Omaha Weather Report" },
            Type = new[] { new AnyUri(ObjectType.Page) },
            Url = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/weather-in-omaha.html")
                }
            }
        });
    }

    [Theory]
    [InlineData("Person_0")]
    public async Task GivenValidPersonJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Person>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Person
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Sally Smith" },
            Type = new[] { new AnyUri(ObjectType.Person) }
        });
    }

    [Theory]
    [InlineData("Place_0")]
    public async Task GivenValidPlaceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Place>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Place
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Work" },
            Type = new[] { new AnyUri(ObjectType.Place) }
        });
    }

    [Theory]
    [InlineData("Place_1")]
    public async Task GivenValidPlaceJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Place>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Place
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Fresno Area" },
            Type = new[] { new AnyUri(ObjectType.Place) },
            Latitude = (float)36.75,
            Longitude = (float)119.7667,
            Radius = 15,
            Units = "miles"
        });
    }

    [Theory]
    [InlineData("Profile_0")]
    public async Task GivenValidProfileJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Profile>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Profile
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally's Profile" },
            Type = new[] { new AnyUri(ObjectType.Profile) },
            Describes = new Person
            {
                Type = new[] { new AnyUri(ObjectType.Person) },
                Name = new RdfLangString { String = "Sally Smith" }
            }
        });
    }

    [Theory]
    [InlineData("Question_0")]
    public async Task GivenValidQuestionJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Question>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Question
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "What is the answer?" },
            Type = new[] { new AnyUri(ObjectType.Question) },
            OneOf = new[]
            {
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "Option A" }
                },
                new Note
                {
                    Type = new[] { new AnyUri(ObjectType.Note) },
                    Name = new RdfLangString { String = "Option B" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Question_1")]
    public async Task GivenValidQuestionJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Question>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Question
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "What is the answer?" },
            Type = new[] { new AnyUri(ObjectType.Question) },
            Closed = new object[] 
            {
                new DateTimeXsd("2016-05-10T00:00:00Z")
            }
        });
    }

    [Theory]
    [InlineData("Read_0")]
    public async Task GivenValidReadJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Read>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Read
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally read a blog post" },
            Type = new[] { new AnyUri(ObjectType.Read) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/posts/1")
                }
            }
        });
    }

    [Theory]
    [InlineData("Reject_0")]
    public async Task GivenValidRejectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Reject>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Reject
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally rejected an invitation to a party" },
            Type = new[] { new AnyUri(ObjectType.Reject) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Invite
                {
                    Type = new[] { new AnyUri(ObjectType.Invite) },
                    Actor = new[]
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://john.example.org")
                        }
                    },
                    Object = new[]
                    {
                        new Event
                        {
                            Type = new[] { new AnyUri(ObjectType.Event) },
                            Name = new RdfLangString { String = "Going-Away Party for Jim" }
                        }
                    }
                }
            }
        });
    }

    [Theory]
    [InlineData("Relationship_0")]
    public async Task GivenValidRelationshipJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Relationship>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Relationship
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally is an acquaintance of John" },
            Type = new[] { new AnyUri(ObjectType.Relationship) },
            Subject = new Person
            {
                Type = new[] { new AnyUri(ObjectType.Person) },
                Name = new RdfLangString { String = "Sally" }
            },
            InnerRelationship = new [] 
            {
                new Object // TODO I'm unsure about this data type
                {
                    //Type = new[] { new AnyUri(ObjectType.Object) },
                    //Id = new Uri("http://purl.org/vocab/relationship/acquaintanceOf")
                    Type = new[] { new AnyUri("http://purl.org/vocab/relationship/acquaintanceOf") }
                }
            },
            Object = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "John" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Remove_0")]
    public async Task GivenValidRemoveJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Remove>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Remove
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally removed a note from her notes folder" },
            Type = new[] { new AnyUri(ObjectType.Remove) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/notes/1")
                }
            },
            Target = new[]
            {
                new Collection
                {
                    Type = new[] { new AnyUri(ObjectType.Collection) },
                    Name = new RdfLangString { String = "Notes Folder" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Remove_1")]
    public async Task GivenValidRemoveJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Remove>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Remove
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "The moderator removed Sally from a group" },
            Type = new[] { new AnyUri(ObjectType.Remove) },
            Actor = new[]
            {
                new Object
                {
                    Type = new [] { new AnyUri(new Uri("http://example.org/Role")) },
                    Name = new RdfLangString { String = "The Moderator" }
                }
            },
            Object = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Origin = new[]
            {
                new Group
                {
                    Type = new[] { new AnyUri(ObjectType.Group) },
                    Name = new RdfLangString { String = "A Simple Group" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Service_0")]
    public async Task GivenValidServiceJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Service>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Service
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Acme Web Service" },
            Type = new[] { new AnyUri(ObjectType.Service) }
        });
    }

    [Theory]
    [InlineData("TentativeAccept_0")]
    public async Task GivenValidTentativeAcceptJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<TentativeAccept>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new TentativeAccept
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally tentatively accepted an invitation to a party" },
            Type = new[] { new AnyUri(ObjectType.TentativeAccept) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Invite
                {
                    Type = new[] { new AnyUri(ObjectType.Invite) },
                    Actor = new[]
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://john.example.org")
                        }
                    },
                    Object = new[]
                    {
                        new Event
                        {
                            Type = new[] { new AnyUri(ObjectType.Event) },
                            Name = new RdfLangString { String = "Going-Away Party for Jim" }
                        }
                    }
                }
            }
        });
    }

    [Theory]
    [InlineData("TentativeReject_0")]
    public async Task GivenValidTentativeRejectJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<TentativeReject>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new TentativeReject
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally tentatively rejected an invitation to a party" },
            Type = new[] { new AnyUri(ObjectType.TentativeReject) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Invite
                {
                    Type = new[] { new AnyUri(ObjectType.Invite) },
                    Actor = new[]
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://john.example.org")
                        }
                    },
                    Object = new[]
                    {
                        new Event
                        {
                            Type = new[] { new AnyUri(ObjectType.Event) },
                            Name = new RdfLangString { String = "Going-Away Party for Jim" }
                        }
                    }
                }
            }
        });
    }

    [Theory]
    [InlineData("Tombstone_0")]
    public async Task GivenValidTombstoneJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<OrderedCollection>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new OrderedCollection
        {
            Name = new RdfLangString { String = "Vacation photos 2016" },
            Type = new[] { new AnyUri(ObjectType.OrderedCollection) },
            TotalItems = 3,
            Items = new ICoreType[]
            {
                new Image
                {
                    Type = new[] { new AnyUri(ObjectType.Image) },
                    Id = new Uri("http://image.example/1")
                },
                new Tombstone
                {
                    Type = new[] { new AnyUri(ObjectType.Tombstone) },
                    //FormerType = new[] { new AnyUri(ObjectType.Image) }, // TODO FIX
                    Id = new Uri("http://image.example/2"),
                    Deleted = new DateTimeXsd("2016-03-17T00:00:00Z")
                },
                new Image
                {
                    Type = new[] { new AnyUri(ObjectType.Image) },
                    Id = new Uri("http://image.example/3")
                }
            }
        });
    }

    [Theory]
    [InlineData("Travel_0")]
    public async Task GivenValidTravelJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Travel>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Travel
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally went to work" },
            Type = new[] { new AnyUri(ObjectType.Travel) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Target = new[]
            {
                new Place
                {
                    Type = new[] { new AnyUri(ObjectType.Place) },
                    Name = new RdfLangString { String = "Work" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Travel_1")]
    public async Task GivenValidTravelJson1_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Travel>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Travel
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally went home from work" },
            Type = new[] { new AnyUri(ObjectType.Travel) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Target = new[]
            {
                new Place
                {
                    Type = new[] { new AnyUri(ObjectType.Place) },
                    Name = new RdfLangString { String = "Home" }
                }
            },
            Origin = new[]
            {
                new Place
                {
                    Type = new[] { new AnyUri(ObjectType.Place) },
                    Name = new RdfLangString { String = "Work" }
                }
            }
        });
    }

    [Theory]
    [InlineData("Undo_0")]
    public async Task GivenValidUndoJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Undo>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Undo
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally retracted her offer to John" },
            Type = new[] { new AnyUri(ObjectType.Undo) },
            Actor = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://sally.example.org")
                }
            },
            Object = new[]
            {
                new Offer
                {
                    Type = new[] { new AnyUri(ObjectType.Offer) },
                    Actor = new[]
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://sally.example.org")
                        }
                    },
                    Object = new[]
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://example.org/posts/1")
                        }
                    },
                    Target = new[]
                    {
                        new Link
                        {
                            Type = new[] { new AnyUri(ObjectType.Link) },
                            Href = new Uri("http://john.example.org")
                        }
                    }
                }
            }
        });
    }

    [Theory]
    [InlineData("Update_0")]
    public async Task GivenValidUpdateJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Update>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Update
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally updated her note" },
            Type = new[] { new AnyUri(ObjectType.Update) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/notes/1")
                }
            }
        });
    }

    [Theory]
    [InlineData("Video_0")]
    public async Task GivenValidVideoJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<Video>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new Video
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Name = new RdfLangString { String = "Puppy Plays With Ball" },
            Type = new[] { new AnyUri(ObjectType.Video) },
            Url = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("http://example.org/video.mkv")
                }
            },
            Duration = TimeSpanHelper.ToTimeSpan("PT2H")
        });
    }

    [Theory]
    [InlineData("View_0")]
    public async Task GivenValidViewJson_WhenDeserialised_ThenSucceedsAsync(string fileName)
    {
        // Arrange
        using var reader = new StreamReader(FileHelper.GetFileLocation($"{fileName}.json", FilePath));

        // Act
        var sut = await JsonSerializer.DeserializeAsync<View>(reader.BaseStream, SerializationOptions.Options);

        // Assert
        sut.Should().BeEquivalentTo(new View
        {
            Context = new[]
            {
                new Link
                {
                    Type = new[] { new AnyUri(ObjectType.Link) },
                    Href = new Uri("https://www.w3.org/ns/activitystreams")
                }
            },
            Summary = new RdfLangString { String = "Sally read an article" },
            Type = new[] { new AnyUri(ObjectType.View) },
            Actor = new[]
            {
                new Person
                {
                    Type = new[] { new AnyUri(ObjectType.Person) },
                    Name = new RdfLangString { String = "Sally" }
                }
            },
            Object = new[]
            {
                new Article
                {
                    Type = new[] { new AnyUri(ObjectType.Article) },
                    Name = new RdfLangString { String = "What You Should Know About Activity Streams" }
                }
            }
        });
    }
}