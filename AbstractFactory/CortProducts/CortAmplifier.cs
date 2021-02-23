using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class CortAmplifier : IAmplifier
    {
        private int _power;

        public CortAmplifier(int power)
        {
            _power = power;
        }

        public int Power { get => _power; set => _power = value; }
    }
}
