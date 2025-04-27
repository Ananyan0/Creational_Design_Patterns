using Iinterface;

namespace Electrical
{

        class ElectricalEngine : IEngine
        {
            public void Engine()
            {
                System.Console.WriteLine("Electrical car has engine");
            }
        }

        class ElectricalCarCreator : ICar
        {
            public IEngine CreateEngine()
            {
                return new ElectricalEngine();
            }

            public IFuel CreateFuel() => null;
        }

    
}
