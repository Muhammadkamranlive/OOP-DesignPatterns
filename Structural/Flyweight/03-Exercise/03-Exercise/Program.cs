using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace _03_Exercise
{
    public class Sentence
    {
        private string text;
        private List<WordToken> words = new List<WordToken>();

        public Sentence(string plainText)
        {
            this.text = plainText;
        }

        public WordToken this[int index]
        {
            get
            {
                var token = new WordToken { index = index };
                words.Add(token);
                return token;
            }
        }

        public override string ToString()
        {
            var sb = new List<string>();
            var words = text.Split(' ').ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];

                foreach (var index in this.words)
                    if (index.isIndex(i) && index.Capitalize)
                        word = word.ToUpper();

                sb.Add(word);
            }

            return string.Join(" ", sb);
        }

        public class WordToken
        {
            public int index;
            public bool Capitalize;

            public bool isIndex(int index)
            {
                return this.index == index;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sentence = new Sentence("hello world");
            sentence[1].Capitalize = true;
            WriteLine(sentence);

            ReadKey();
        }
    }
}
