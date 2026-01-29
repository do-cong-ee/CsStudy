using System;
using System.Threading;

namespace Synchronize
{
    class Counter
    {
        const int LOOP_COUNT = 10000;
        readonly object thislock;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            thislock = new object();
            count = 0;
        }

        public void Increase()
        {
            this.LOOP_COUNT = 20;

            int loopCount = LOOP_COUNT;
        }
    }
}