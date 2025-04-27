using Iinterface;

namespace Diesel
{
        class DieselEngine : IEngine
        {
            public void Engine()
            {
                System.Console.WriteLine("Diesel car has engine");
            }
        }

        class DieselFuel : IFuel
        {
            public void Fuel()
            {
                System.Console.WriteLine("Diesel car has fuel tank");
            }
        }

        class DieselCarCreator : ICar
        {
            public IEngine CreateEngine()
            {
                return new DieselEngine();
            }

            public IFuel CreateFuel()
            {
                return new DieselFuel();
            }
        }
}
