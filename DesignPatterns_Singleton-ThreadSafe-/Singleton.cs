using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns_Singleton_ThreadSafe_
{
    class Singleton
    {
        private static Singleton _instance;
        private int _counter;
        private static object obj = new object();
        private static object obj2 = new object();
        private Singleton()
        {
            _counter = 0;
        }

        public static Singleton GetInstance()
        {
            lock (obj)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }

        }

        public void AddOneToCounter()
        {
            lock (obj2)
            {
                var state = _counter;
                Thread.Sleep(1000);
                _counter = state + 1;
            }
        }

        public int GetCounter()
        {
            return _counter;
        }
    }
}
