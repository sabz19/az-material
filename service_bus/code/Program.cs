// See https://aka.ms/new-console-template for more information

QueueClient queueClient = new QueueClient(connectionString, queueName);

queueClient.CreateIfNotExists();

if(queueClient.Exists())
{
    queueClient.SendMessage("Message1");
}
