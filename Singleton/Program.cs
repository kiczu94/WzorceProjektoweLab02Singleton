using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You should see the same text or I will have troubles");

            Thread proccess1 = new Thread(() => GetInstanceOfSingleton("Value number one"));
            Thread proccess2 = new Thread(() => GetInstanceOfSingleton("Value number two"));
            Thread proccess3 = new Thread(() => GetInstanceOfSingleton("Value number three"));
            Thread proccess4 = new Thread(() => GetInstanceOfSingleton("Value number four"));
            Thread proccess5 = new Thread(() => GetInstanceOfSingleton("Value number five"));
            Thread proccess6 = new Thread(() => GetInstanceOfSingleton("Value number six"));

            proccess1.Start();
            proccess2.Start();
            proccess3.Start();
            proccess4.Start();
            proccess5.Start();
            proccess6.Start();

            proccess1.Join();
            proccess2.Join();
            proccess3.Join();
            proccess4.Join();
            proccess5.Join();
            proccess6.Join();

        }

        public static void GetInstanceOfSingleton(string value)
        {
            var singleton = SingletonClass.GetInstance(value);
            Console.WriteLine(singleton.singletonValue);
        }
    }
}
