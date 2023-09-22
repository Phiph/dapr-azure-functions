using System;
using System.IO;
using System.Threading.Tasks;
using CloudNative.CloudEvents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Dapr;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp;

public static class HandleBundleMessage
{
    [FunctionName("HandleBundleMessage")]
    public static void Run(
        [DaprTopicTrigger("%PubSubName%", Topic = "StartBundle")] CloudEvent subEvent,
        ILogger log)
    {
        log.LogInformation("C# function processed a PrintTopicMessage request from the Dapr Runtime.");
        log.LogInformation($"Topic B received a message: {subEvent.Data}.");
    }  
    
}