namespace _02_EventBroker.Actions
{
    public class PlayerSentOffEvent : PlayerEvent
    {
        public string Reason { get; set; }
    }
}
