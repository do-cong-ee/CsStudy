using System;
using System.IO;

namespace chu_sang_class
{
    abstract class AbstractBase
    {
        public abstract void SomeMathod();
    }

    class Derived : AbstractBase
    {
        public override void SomeMathod()
        {
            //something;
        }
    }
}