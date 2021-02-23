using System;

namespace AbstractFactory
{
    public static class Program
    {
        private static void Main()
        {
            IAbstractFactory fenderFactory = new FenderConcreteFactory();
            Console.WriteLine("********* Fender **********");
            Client fenderClient = new Client(fenderFactory);
            Console.WriteLine($"{fenderClient.GetGuitarName()} {fenderClient.GetAmplifierPower()}");

            IAbstractFactory cortFactory = new CortConcreteFactory();
            Console.WriteLine("********* Cort **********");
            Client cortClient = new Client(cortFactory);
            Console.WriteLine($"{cortClient.GetGuitarName()} {cortClient.GetAmplifierPower()}");
        }
    }
}