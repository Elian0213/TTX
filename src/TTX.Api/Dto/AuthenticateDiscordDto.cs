using System.Text.Json.Serialization;
using TTX.Commands.Players.AuthenticateDiscordUser;

namespace TTX.Api.Dto;

public class AuthenticateDiscordUserDto(AuthenticateDiscordUserResult result)
{
    [JsonPropertyName("access_token")] public string Token { get; } = result.User.Token;

    [JsonPropertyName("twitch_users")]
    public TwitchUserDto[] TwitchUsers { get; } = [.. result.TwitchUsers.Select(c => TwitchUserDto.Create(c))];
}
