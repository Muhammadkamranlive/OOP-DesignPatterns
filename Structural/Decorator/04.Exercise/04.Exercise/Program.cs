using System;

namespace _04.Exercise
{
    class Program
    {
        public class Bird
        {
            public int Age { get; set; }

            public string Fly()
            {
                return (Age < 10) ? "flying" : "too old";
            }
        }

        public class Lizard
        {
            public int Age { get; set; }

            public string Crawl()
            {
                return (Age > 1) ? "crawling" : "too young";
            }
        }

        public class Dragon // no need for interfaces
        {
            private Lizard lizard = new Lizard();
            private Bird bird = new Bird();
            private int age;

            public int Age
            {
                set { age = bird.Age = lizard.Age = value; }
                get { return age; }
            }

            public string Fly()
            {
                return bird.Fly();
            }

            public string Crawl()
            {
                return lizard.Crawl();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
