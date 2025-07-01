using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Identity;
using System.Text;


string namespaceURL = "namespace1";
string eventHubName = "eventhub1";

DefaultAzureCredentialOptions options = new()
{
    ExcludeEnvironmentCredential = true,
    ExcludeManagedIdentityCredential = true
};

int numOfEvents = 3;

EventHubProducerClient producerClient = new EventHubProducerClient(
    namespaceURL,
    eventhub1,
    new DefaultAzureCredentialOptions(options)
);

