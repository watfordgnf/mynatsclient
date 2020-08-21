namespace MyNatsClient.Events
{
    public class ClientReconnecting : IClientEvent
    {
        public INatsClient Client { get; }

        public int Attempts { get; }

        public ClientReconnecting(NatsClient client, int attempts)
        {
            Client = client;
            Attempts = attempts;
        }
    }
}
