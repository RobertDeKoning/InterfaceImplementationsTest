using InterfaceImplementationsTest.Implementations;
using InterfaceImplementationsTest.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using Test.Data;

namespace InterfaceImplementationsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<NewContext>(ServiceLifetime.Transient);
            services.AddTransient<IRunProgram, RunProgram>();
            services.AddTransient<IValidationFactory, ValidationFactory>();
            var provider = services.BuildServiceProvider();
            
            var instance = provider.GetService<IRunProgram>();

            instance.GetValidator("Canon001");
            instance.GetValidator("bullshit");
        }
    }
}
