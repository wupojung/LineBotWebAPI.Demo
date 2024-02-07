using Line.Messaging;

namespace LineBot.Services;

public interface ILineService
{
    Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message);
}