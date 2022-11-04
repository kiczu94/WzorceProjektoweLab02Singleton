using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SingletonClass
    {
        public string singletonValue { get; set; }

        private static SingletonClass _instance;

        private static readonly object _lock = new object();
        private SingletonClass() { }

        public static SingletonClass GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance==null)
                    {
                        _instance = new SingletonClass();
                        _instance.singletonValue = value;
                    }
                }
            }
            return _instance;
        }
    }
}
