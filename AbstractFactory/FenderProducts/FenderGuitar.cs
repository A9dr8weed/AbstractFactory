using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class FenderGuitar : IGuitar
    {
        private string _name;

        public FenderGuitar(string name)
        {
            Console.Write("Fender guitar constructor: ");
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
