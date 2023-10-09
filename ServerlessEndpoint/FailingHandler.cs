using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace LambdaFunctions;

public class FailingHandler : IHandleMessages<FailingMessage>
{
    static readonly ILog Log = LogManager.GetLogger<FailingHandler>();

    public Task Handle(FailingMessage message, IMessageHandlerContext context)
    {
        Log.Info($"Handling {nameof(FailingMessage)} in ServerlessEndpoint. Throwing exception");
        throw new Exception("error");
    }
}