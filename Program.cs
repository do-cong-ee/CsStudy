using System;
using System.Collections;
using System.Collections.Generic;

namespace MyException
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException()
        {

        }
        public InvalidArgumentException(string massage) : base(massage)
        {

        }

        public object Argument
        {
            get; set;
        }
        public string range
        {
            get; set;
        }
    }

    class MainApp
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };

            foreach(uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException()
                    {
                        Argument = arg,
                        range = "0-255"
                    };

                
            }

            return (alpha << 24 & 0xFF00000);
        }
    }
}