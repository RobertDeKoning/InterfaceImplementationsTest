using InterfaceImplementationsTest.Interfaces;

namespace InterfaceImplementationsTest
{
    public class RunProgram : IRunProgram
    {
        private IValidationFactory _validationFactory;

        public RunProgram(IValidationFactory validationFactory)
        {
            _validationFactory = validationFactory;
        }

        public void GetValidator(string fileName)
        {
            var a = _validationFactory.CreateValidator(fileName);
            var aBool = a.IsFileValid();
        }

    }
}
