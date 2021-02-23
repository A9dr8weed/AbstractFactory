using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class FenderAmplifier : IAmplifier
    {
        private int _power;

        public FenderAmplifier(int power)
        {
            _power = power;
        }

        public int Power { get => _power; set => _power = value; }
    }
}