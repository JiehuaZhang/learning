using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.SingletonPatter
{
    public class Singleton
    {
        private static Singleton instance;
        private string Name { get; set; }
        private string IP { get; set; }

        private Singleton()
        {
            Console.WriteLine("Singleton Instance");
            Name = "Server1";
            IP = "192.168.1.23";
        }

        private static readonly object syncLock = new object();

        public static Singleton Instance
        {
            get
            {
                // Support multithreaded applications through
                // 'Double checked locking' pattern which (once
                // the instance exists) avoids locking each
                // time the method is invoked
                lock (syncLock)
                {
                    if(instance != null)
                       instance = new Singleton();
                    return instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine($"Server Information is : Name ={Name} & IP ={IP} ");
        }
    }
}
