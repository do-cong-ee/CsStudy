using System;
using System.Security.Permissions;
using System.Threading;

namespace InterruptingThread
{
    class SideTask
    {
        int count;

        public SideTask (int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {

        }
    }
}