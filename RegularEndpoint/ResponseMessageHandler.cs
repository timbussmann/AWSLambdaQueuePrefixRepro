using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

public class ResponseMessageHandler : IHandleMessages<ResponseMessage>, IHandleMessages<ReplyMessage>
{
    static readonly ILog Log = LogManager.GetLogger<ResponseMessageHandler>();

    public Task Handle(ResponseMessage message, IMessageHandlerContext context)
    {
        Log.Info($"Handling {nameof(ResponseMessage)} in RegularEndpoint");
        return Task.CompletedTask;
    }

    public Task Handle(ReplyMessage message, IMessageHandlerContext context)
    {
        Log.Info($"Handling {nameof(ReplyMessage)} in RegularEndpoint");
        return Task.CompletedTask;
    }
}