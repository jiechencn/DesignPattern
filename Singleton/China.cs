using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class China
    {
        // lazy initialization (it is thread safe)
        private static readonly Lazy<China> chinaLock = new Lazy<China>(new China());
        private China()
        {
            System.Console.WriteLine("I am the only one China in the world");
        }

        public static China GetInstance()
        {
            return chinaLock.Value;
        }
        
    }
}
