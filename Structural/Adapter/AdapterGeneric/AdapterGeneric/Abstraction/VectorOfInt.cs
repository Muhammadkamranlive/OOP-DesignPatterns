using AdapterGeneric.Interface;

namespace AdapterGeneric.Abstraction
{
    public class VectorOfInt<D> : Vector<VectorOfInt<D>, int, D> where D : IInteger, new()
    {
        public VectorOfInt() { }

        public VectorOfInt(params int[] values) : base(values) { }

        public static VectorOfInt<D> operator + (VectorOfInt<D> left, VectorOfInt<D> right)
        {
            var result = new VectorOfInt<D>();
            var dim = new D().Value;

            for(int i = 0; i < dim; i++)
            {
                result[i] = left[i] + right[i];
            }
            return result;
        }
    }
}
