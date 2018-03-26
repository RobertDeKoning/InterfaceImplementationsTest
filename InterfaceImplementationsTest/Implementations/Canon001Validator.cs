using InterfaceImplementationsTest.Interfaces;

namespace InterfaceImplementationsTest.Implementations
{
    public class Canon001Validator : IValidator
    {
        public bool IsFileValid()
        {
            return true;
        }
    }
}
