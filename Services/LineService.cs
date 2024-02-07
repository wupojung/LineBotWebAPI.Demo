using Line.Messaging;
using Line.Messaging.Webhooks;

namespace LineBot.Services;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage("Hello~")
        };
        return result;
    }
}