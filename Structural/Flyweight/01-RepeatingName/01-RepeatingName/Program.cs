using JetBrains.dotMemoryUnit;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace _01_RepeatingName
{
    [TestFixture]
    public class Demo
    {
        static void Main(string[] args)
        {
        }

        [Test]
        public void TestUser()
        {
            var firstName = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastName = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User>();

            foreach (var first in firstName)
                foreach (var last in lastName)
                    users.Add(new User($"{first} {last}"));

            ForceGB();

            dotMemory.Check(memory =>
            {
                WriteLine(memory);
            });
        }

        [Test]
        public void TestUser2()
        {
            var firstName = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastName = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User2>();

            foreach (var first in firstName)
                foreach (var last in lastName)
                    users.Add(new User2($"{first} {last}"));

            ForceGB();

            dotMemory.Check(memory =>
            {
                WriteLine(memory);
            });
        }

        private void ForceGB()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string RandomString()
        {
            Random rand = new Random();
            return new string(
                Enumerable.Range(0,10)
                .Select(i => (char)('a' + rand.Next(26)))
                .ToArray());
        }
    }
}
