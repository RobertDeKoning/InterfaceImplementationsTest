namespace InterfaceImplementationsTest.Interfaces
{
    public interface IValidationFactory
    {
        T CreateValidator<T>() where T : IValidator, new();

        IValidator CreateValidator(string fileName);

        //Type GetValidationType(string fileName);
    }
}
