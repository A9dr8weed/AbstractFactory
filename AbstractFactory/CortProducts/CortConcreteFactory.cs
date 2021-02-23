namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class.
    /// </summary>
    public class CortConcreteFactory : IAbstractFactory
    {
        public IAmplifier GetAmplifier()
        {
            return new CortAmplifier(15);
        }

        public IGuitar GetGuitar()
        {
            return new CortGuitar("Cort SFX ME-OP");
        }
    }
}