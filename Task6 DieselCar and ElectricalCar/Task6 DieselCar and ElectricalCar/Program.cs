using Diesel;
using Electrical;
using Iinterface;

class Program
{
    static void Main(string[] args)
    {
        ICar dieselCar = new DieselCarCreator();
        IEngine dieselEngine = dieselCar.CreateEngine();
        IFuel dieselFuel = dieselCar.CreateFuel();

        dieselEngine.Engine();
        dieselFuel.Fuel();

        System.Console.WriteLine();

        ICar electricalCar = new ElectricalCarCreator();
        IEngine electricalEngine = electricalCar.CreateEngine();
        IFuel electricalFuel = electricalCar.CreateFuel();

        electricalEngine.Engine();

        if(electricalFuel == null) System.Console.WriteLine("Electrical car doesn't have fuel tank");
    }
}