using System.Diagnostics.CodeAnalysis;

namespace Telegram.Bot.Types.ReplyMarkups;

/// <summary>
/// This object defines the criteria used to request a suitable chat. The identifier of the selected chat will be
/// shared with the bot when the corresponding button is pressed.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class KeyboardButtonRequestChat
{
    /// <summary>
    /// Signed 32-bit identifier of the request, which will be received back in the <see cref="ChatShared"/> object.
    /// Must be unique within the message
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public required int RequestId { get; init; }

    /// <summary>
    /// Pass <see langword="true"/> to request a channel chat, pass <see langword="false"/>
    /// to request a group or a supergroup chat.
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public required bool ChatIsChannel { get; init; }

    /// <summary>
    /// Optional. Pass <see langword="true" /> to request a forum supergroup, pass <see langword="false" /> to
    /// request a non-forum chat. If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? ChatIsForum { get; set; }

    /// <summary>
    /// Optional. Pass <see langword="true" /> to request a supergroup or a channel with a username,
    /// pass <see langword="false" /> to request a chat without a username. If not specified, no additional
    /// restrictions are applied.
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? ChatHasUsername { get; set; }

    /// <summary>
    /// Optional. Pass <see langword="true" /> to request a chat owned by the user. Otherwise, no additional
    /// restrictions are applied.
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? ChatIsCreated { get; set; }

    /// <summary>
    /// Optional. A JSON-serialized object listing the required administrator rights of the user in the chat.
    /// If not specified, no additional restrictions are applied.
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public ChatAdministratorRights? UserAdministratorRights { get; set; }

    /// <summary>
    /// Optional. A JSON-serialized object listing the required administrator rights of the bot in the chat.
    /// The rights must be a subset of <see cref="ChatAdministratorRights" />. If not specified, no additional
    /// restrictions are applied.
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public ChatAdministratorRights? BotAdministratorRights { get; set; }

    /// <summary>
    /// Optional. Pass <see langword="true" /> to request a chat with the bot as a member. Otherwise, no additional
    /// restrictions are applied.
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool BotIsMember { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KeyboardButtonRequestChat"/> class with requestId and chatIsChannel
    /// </summary>
    /// <param name="requestId">
    /// Signed 32-bit identifier of the request, which will be received back in the <see cref="ChatShared"/> object.
    /// Must be unique within the message
    /// </param>
    /// <param name="chatIsChannel">
    /// Pass <see langword="true"/> to request a channel chat, pass <see langword="false"/>
    /// to request a group or a supergroup chat.
    /// </param>
    [SetsRequiredMembers]
    public KeyboardButtonRequestChat(int requestId, bool chatIsChannel)
    {
        RequestId = requestId;
        ChatIsChannel = chatIsChannel;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="KeyboardButtonRequestChat"/> class
    /// </summary>
    public KeyboardButtonRequestChat()
    { }
}
