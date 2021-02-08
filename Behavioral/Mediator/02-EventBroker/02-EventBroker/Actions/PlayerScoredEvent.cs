namespace _02_EventBroker.Actions
{
    public class PlayerScoredEvent : PlayerEvent
    {
        public int GoalsScored { get; set; }
    }
}
