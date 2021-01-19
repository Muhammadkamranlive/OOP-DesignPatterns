namespace _04_CompositeProxy_SoA_AoS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Memory
            // Age X Y Age X Y
            var creatures = new Creature[100]; //AoS = array of structures
            foreach (var c in creatures)
            {
                c.X++;
            }

            // Memory
            // Age Age
            // X X 
            // Y Y
            var creature2 = new Creatures(100); // SoA = structure of arrays
            foreach (var c in creature2)
            {
                c.X++;
            }
        }
    }
}
