using System.Net;
using Azure.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Dapr;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp
{
    public static class PrintTopicMessage
    { 
        /// <summary>
        /// Sample to use Dapr Publish trigger to print any new message arrived on the subscribed topic.
        /// </summary>
        [Function("PrintTopicMessage")]
        public static void Run(
            [DaprTopicTrigger("%PubSubName%", Topic = "message")] CloudEvent subEvent, FunctionContext functionContext)
        {
            var log = functionContext.GetLogger("PrintTopicMessage");
            log.LogInformation("C# function processed a PrintTopicMessage request from the Dapr Runtime.");
            log.LogInformation($"Topic B received a message: {subEvent.Data}.");
        }
    }
}
