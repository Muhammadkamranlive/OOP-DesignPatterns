using AdapterGeneric.Abstraction;

namespace AdapterGeneric
{
    public class Vector2i : VectorOfInt<Dimensions.Two>
    {
        public Vector2i() { }

        public Vector2i(params int[] values) : base(values) { }
    }
}
