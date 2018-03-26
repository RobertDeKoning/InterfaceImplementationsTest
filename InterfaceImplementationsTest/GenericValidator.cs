using InterfaceImplementationsTest.Interfaces;

namespace InterfaceImplementationsTest
{
    public class GenericValidator<T> : IGenericValidator<T> where T : IValidator
    {

    }
}
