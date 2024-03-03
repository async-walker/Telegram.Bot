namespace Telegram.Bot.Types;

/// <summary>
/// This object represents a service message about a forum topic closed in the chat. Currently holds no information.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ForumTopicClosed;