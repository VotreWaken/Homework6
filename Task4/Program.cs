using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new President();
            Worker worker2 = new Security();
            Worker worker3 = new Manager();
            Worker worker4 = new Engineer();
            worker1.Print();
            worker2.Print();
            worker3.Print();
            worker4.Print();
        }

        abstract class Worker
        {
            public abstract void Print();
        }
        class President : Worker
        {
            public override void Print()
            {
                Console.WriteLine("President");
            }
        }
        class Security : Worker
        {
            public override void Print()
            {
                Console.WriteLine("Security");
            }
        }
        class Manager : Worker
        {
            public override void Print()
            {
                Console.WriteLine("Manager");
            }
        }
        class Engineer : Worker
        {
            public override void Print()
            {
                Console.WriteLine("Engineer");
            }
        }
    }
}
