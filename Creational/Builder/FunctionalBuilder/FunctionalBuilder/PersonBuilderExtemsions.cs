
namespace FunctionalBuilder
{
    public static class PersonBuilderExtemsions
    {
        public static PersonBuilder WorskAs(this PersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);
    }
}
