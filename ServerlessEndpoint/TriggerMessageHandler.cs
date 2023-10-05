using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

public class TriggerMessageHandler : IHandleMessages<TriggerMessage>
{
    static readonly ILog Log = LogManager.GetLogger<TriggerMessageHandler>();

    public async Task Handle(TriggerMessage message, IMessageHandlerContext context)
    {
        Log.Info($"Handling {nameof(TriggerMessage)} in ServerlessEndpoint.");
        await context.Send(new ResponseMessage()); // use routing config
        await context.Reply(new ReplyMessage()); // use replyto address
    }
}
