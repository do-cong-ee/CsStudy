using System;

namespace ReadOnlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public readonly double GetFahrenheit()
        {
            //target = currentInCelsius * 1.8 + 32;
            return currentInCelsius * 1.8 + 32;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {

        }
    }
}