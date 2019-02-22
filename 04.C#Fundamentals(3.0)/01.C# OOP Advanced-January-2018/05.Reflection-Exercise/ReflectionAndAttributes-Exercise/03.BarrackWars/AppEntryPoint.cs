namespace _03BarracksFactory
{
    using _03BarrackWars.Core;
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;
    using System;
    using Microsoft.Extensions.DependencyInjection;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureService();

            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();

            ICommandInterpreter commandInterpreter = new CommandInterpreter(repository, unitFactory);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
          var a = new ServiceCollection
        }
    }
}
