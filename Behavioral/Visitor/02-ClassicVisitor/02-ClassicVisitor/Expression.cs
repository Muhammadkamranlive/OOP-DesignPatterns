namespace _02_ClassicVisitor
{
    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }
}
