namespace BuilderInheritanceWithRecursiveGenerics
{
    public class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}
