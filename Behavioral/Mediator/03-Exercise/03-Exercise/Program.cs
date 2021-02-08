using System.Collections.Generic;

namespace _03_Exercise
{
    class Program
    {
        public class Participant
        {
            private Mediator mediator;

            public int Value { get; set; }

            public Participant(Mediator mediator)
            {
                Value = 0;
                this.mediator = mediator;
                this.mediator.participants.Add(this);
            }

            public void Say(int n)
            {
                mediator.Broadcast(n, this);
            }
        }

        public class Mediator
        {
            public List<Participant> participants = new List<Participant>();

            public void Broadcast(int value, Participant sender)
            {
                foreach(var p in participants)
                {
                    if (p != sender)
                        p.Value += value;
                }
            }
        }


        static void Main(string[] args)
        {
        }
    }
}
