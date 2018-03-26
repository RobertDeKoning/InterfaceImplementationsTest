using InterfaceImplementationsTest.Enums;
using InterfaceImplementationsTest.Interfaces;
using System;

namespace InterfaceImplementationsTest.Implementations
{
    public class ValidationFactory : IValidationFactory
    {
        public T CreateValidator<T>() where T : IValidator, new()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public IValidator CreateValidator(string fileName)
        {
            var type = GetValidationType(fileName);
            return (IValidator)Activator.CreateInstance(type);
        }

        private Type GetValidationType(string fileName)
        {
            var templateNameLength = fileName.IndexOf('_');
            if(templateNameLength == -1)
            {
                templateNameLength = fileName.Length;
            }
            var template = fileName.Substring(0,templateNameLength);
            if (Enum.TryParse<TemplateEnum>(template, true, out TemplateEnum templateEnum))
            {
                switch (templateEnum)
                {
                    case TemplateEnum.Canon001:
                        return typeof(Canon001Validator);
                    case TemplateEnum.Canon002:
                        return typeof(Canon002Validator);
                    case TemplateEnum.Canon003:
                        return typeof(Canon003Validator);
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                return typeof(NullValidator);
            }

        }

    }
}
