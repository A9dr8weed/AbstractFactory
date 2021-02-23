namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class.
    /// </summary>
    public class FenderConcreteFactory : IAbstractFactory
    {
        public IAmplifier GetAmplifier()
        {
            return new FenderAmplifier(25);
        }

        public IGuitar GetGuitar()
        {
            return new FenderGuitar("Fender stratocaster");
        }
    }
}