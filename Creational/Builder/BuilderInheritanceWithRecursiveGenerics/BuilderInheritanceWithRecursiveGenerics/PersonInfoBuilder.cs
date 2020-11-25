namespace BuilderInheritanceWithRecursiveGenerics
{
    // Only one situation where SELF actually refers to the objec inheriting from this object
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }
}
