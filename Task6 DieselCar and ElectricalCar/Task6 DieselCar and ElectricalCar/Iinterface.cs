namespace Iinterface
{
        public interface IEngine
        {
            void Engine();
        }

        public interface IFuel
        {
            void Fuel();
        }

        public interface ICar
        {
            IEngine CreateEngine();
            IFuel CreateFuel();
        }
    
}