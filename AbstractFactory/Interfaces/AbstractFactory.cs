namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' interface
    /// </summary>
    public interface IAbstractFactory
    {
        IGuitar GetGuitar();
        IAmplifier GetAmplifier();
    }
}