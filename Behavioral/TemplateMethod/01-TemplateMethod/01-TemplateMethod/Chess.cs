using static System.Console;

namespace _01_TemplateMethod
{
    public class Chess : Game
    {
        protected override bool HaveWinner => turn == maxTurns;
        protected override int WinningPlayer => currentPlayer;
        private int maxTurns = 10;
        private int turn = 1;

        public Chess() : base(2)
        {
        }

        protected override void Start()
        {
            WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
        }

        protected override void TakeTurn()
        {
            WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }
    }
}
