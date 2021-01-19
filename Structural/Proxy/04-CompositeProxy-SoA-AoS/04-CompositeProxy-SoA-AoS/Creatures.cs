using System.Collections.Generic;

namespace _04_CompositeProxy_SoA_AoS
{
    public class Creatures
    {
        private readonly int size;
        private byte[] age;
        private int[] x, y;

        public Creatures(int size)
        {
            this.size = size;
            age = new byte[size];
            x = new int[size];
            y = new int[size];
        }

        public IEnumerator<CreatureProxy> GetEnumerator()
        {
            for (int i = 0; i < size; ++i)
                yield return new CreatureProxy(this, i);
        }

        public struct CreatureProxy
        {
            private readonly Creatures creatures;
            private readonly int index;

            public CreatureProxy(Creatures creatures, int index)
            {
                this.index = index;
                this.creatures = creatures;
            }

            public ref byte Age => ref creatures.age[index];
            public ref int X => ref creatures.x[index];
            public ref int Y => ref creatures.y[index];
        }
    }
}
