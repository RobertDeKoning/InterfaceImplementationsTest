using InterfaceImplementationsTest.Interfaces;

namespace InterfaceImplementationsTest.Implementations
{
    public class NullValidator : IValidator
    {
        public bool IsFileValid()
        {
            return false;
        }
    }
}
