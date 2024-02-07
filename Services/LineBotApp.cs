using Line.Messaging;
using Line.Messaging.Webhooks;
using LineBot.Services;

public class LineBotApp : WebhookApplication
{
    private readonly LineMessagingClient _messagingClient;


    private readonly ILineService _lineService;

    public LineBotApp(LineMessagingClient lineMessagingClient, ILineService lineService)
    {
        _messagingClient = lineMessagingClient;
        _lineService = lineService;
    }

    protected override async Task OnMessageAsync(MessageEvent ev)
    {
        var result = null as List<ISendMessage>;

        switch (ev.Message)
        {
            //文字訊息
            case TextEventMessage textMessage:
            {
                //頻道Id
                string channelId = ev.Source.Id;
                //使用者Id
                string userId = ev.Source.UserId;
                //使用者輸入的文字
                string text = textMessage.Text;

                result = await _lineService.ProcessTextEventMessageAsync(channelId, userId, text);
            }
                break;
        }

        if (result != null)
            await _messagingClient.ReplyMessageAsync(ev.ReplyToken, result);
    }
}