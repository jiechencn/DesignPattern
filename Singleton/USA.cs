using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class USA
    {
        private static USA instance = null;
        private static readonly object objectLock = new object();
        private USA()
        {
            System.Console.WriteLine("I am the only one USA in the world");
        }
        public static USA GetInstance()
        {
            // double checked locking
            if (instance == null)
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new USA();
                    }
                }
            }
            return instance;
        }
    }
}
