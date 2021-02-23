namespace AbstractFactory
{
    public class Client
    {
        private readonly IGuitar _guitar;
        private readonly IAmplifier _amplifier;

        public Client(IAbstractFactory abstractFactory)
        {
            _guitar = abstractFactory.GetGuitar();
            _amplifier = abstractFactory.GetAmplifier();
        }

        public string GetGuitarName()
        {
            return _guitar.Name;
        }

        public int GetAmplifierPower()
        {
            return _amplifier.Power;
        }
    }
}