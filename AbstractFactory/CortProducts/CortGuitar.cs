using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class CortGuitar : IGuitar
    {
        private string _name;

        public CortGuitar(string name)
        {
            Console.Write("Cort guitar constructor: ");
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}